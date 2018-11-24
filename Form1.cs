using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WaveFunctionCollapseEditor
{
    public partial class Form1 : Form
    {
        Model model;
        Bitmap img;
        Random random = new Random();
        bool writingSettings;
        BackgroundWorker worker = new BackgroundWorker();
        Queue<string> logQueue = new Queue<string>();
        string outstr = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load("samples.xml");
            foreach (XElement xelem in xdoc.Root.Elements("overlapping", "simpletiled"))
                listSamples.Items.Add(new WaveFunctionSample(xelem));

            worker.DoWork += runCalc;
            worker.WorkerSupportsCancellation = true;

            saveFileDialog.AddExtension = true;

            Size = new Size(733, 757);
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
                recalcWaveFunc();
        }

        private void rSimpleTiled_CheckedChanged(object sender, EventArgs e)
        {
            updPanels();
            recalcWaveFunc();
        }

        private void rOverlapping_CheckedChanged(object sender, EventArgs e)
        {
            updPanels();
            recalcWaveFunc();
        }

        void updPanels()
        {
            panelTiled.Enabled = rSimpleTiled.Checked;
            panelOverlapping.Enabled = rOverlapping.Checked;
        }

        private void log(string msg)
        {
            msg = $"\r\n{DateTime.Now}: {msg}";
            if (update.Enabled && txtLog.InvokeRequired)
                logQueue.Enqueue(msg);
            else
                txtLog.AppendText(msg);
        }

        private void listSamples_SelectedIndexChanged(object sender, EventArgs e)
        {
            writingSettings = true;
            openFile.FileName = "";
            stSubset.Text = "";
            if (listSamples.SelectedItem is WaveFunctionSample wfs)
            {
                var xelem = wfs.Data;
                sName.Text = xelem.Get<string>("name");
                sPeriodic.Checked = xelem.Get("periodic", false);
                sLimit.Value = xelem.Get("limit", 0);
                sTextOutput.Checked = xelem.Get("textOutput", false);
                if (xelem.Name == "overlapping")
                {
                    oN.Value = xelem.Get("N", 2);
                    sWidth.Value = xelem.Get("width", 48);
                    sHeight.Value = xelem.Get("height", 48);
                    oPeriodicInput.Checked = xelem.Get("periodicInput", true);
                    oSymmetry.Value = xelem.Get("symmetry", 8);
                    oGround.Value = xelem.Get("ground", 0);
                    rOverlapping.Checked = true;
                }
                else if (xelem.Name == "simpletiled")
                {
                    stSubset.Text = xelem.Get<string>("subset");
                    sWidth.Value = xelem.Get("width", 10);
                    sHeight.Value = xelem.Get("height", 10);
                    stBlack.Checked = xelem.Get("black", false);
                    rSimpleTiled.Checked = true;
                }
                else
                    throw new NotImplementedException();
            }
            updPanels();
            writingSettings = false;
            recalcWaveFunc();
        }

        private void cmdSaveImage_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "PNG Image (*.png)|*.png";
            saveFileDialog.DefaultExt = "png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                model?.Graphics().Save(saveFileDialog.FileName);
        }

        private void cmdSaveText_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text Instructions (*.txt)|*.txt";
            saveFileDialog.DefaultExt = "txt";
            if (model is SimpleTiledModel stm && saveFileDialog.ShowDialog() == DialogResult.OK)
                System.IO.File.WriteAllText(saveFileDialog.FileName, stm.TextOutput());
        }

        private void settingChanged(object sender, EventArgs e)
        {
            recalcWaveFunc();
        }

        private void cmdRecalc_Click(object sender, EventArgs e)
        {
            if (worker.IsBusy)
                tryAbort();
            else
                recalcWaveFunc();
        }

        private Bitmap zoomedImage(Bitmap bmp, int zoom) => new Bitmap(bmp, new Size(bmp.Width * zoom, bmp.Height * zoom));

        private void update_Tick(object sender, EventArgs e)
        {
            while (logQueue.Count > 0)
                txtLog.AppendText(logQueue.Dequeue());

            if (!worker.IsBusy)
            {
                update.Enabled = false;
                cmdSaveText.Enabled = outstr.Length > 0;
                cmdRun.Text = "Run";

                if (img != null)
                {
                    picOutput.Image = zoomedImage(img, (int)zoom.Value);
                    picOutput.Size = new Size(picOutput.Image.Width, picOutput.Image.Height);

                    var X = 6;
                    var Y = 6;
                    var w = img.Width;
                    var h = img.Height;
                    tiles.Size = new Size(w * X, h * Y);
                    tiles.Left = picOutput.Right + 12;

                    tiles.Controls.Clear();
                    for (int x = 0; x < X; x++)
                        for (int y = 0; y < Y; y++)
                        {
                            var p = new PictureBox();
                            p.Image = img;
                            p.Size = new Size(w, h);
                            p.Location = new Point(x * w, y * h);
                            tiles.Controls.Add(p);
                        }
                }
            }
        }

        bool tryAbort()
        {
            if (worker.IsBusy)
            {
                worker.CancelAsync();
                log("Aborting");
                var start = DateTime.Now;
                while (true)
                {
                    if (!worker.CancellationPending)
                    {
                        log("Aborted");
                        return true;
                    }
                    else if (DateTime.Now - TimeSpan.FromSeconds(2) > start)
                    {
                        log("Abortion timeout, please wait for thread to finish.");
                        return false;
                    }
                }
            }
            return true;
        }

        public void recalcWaveFunc()
        {
            if (writingSettings)
                return;

            if (!tryAbort())
                return;
            worker.RunWorkerAsync();
            log("Started");
            cmdRun.Text = "Cancel";
            update.Enabled = true;
            if (rndSeed.Checked)
                numSeed.Value = random.Next();

            if (openFile.FileName.Length > 0)
            {
                picInput.ImageLocation = openFile.FileName;
                picInput.Visible = true;
                picGroup.Visible = false;
            }
            else
            {
                var path = "samples/" + sName.Text;
                if (File.Exists(path + ".png"))
                {
                    picInput.ImageLocation = path + ".png";
                    picInput.Visible = true;
                    picGroup.Visible = false;
                }
                else if (Directory.Exists(path)) // create picboxes for each file
                {
                    picInput.Visible = false;
                    picGroup.Visible = true;
                    picGroup.Controls.Clear();
                    {
                        var paths = Directory.GetFiles(path);
                        foreach (var item in paths)
                        {
                            if (Path.GetExtension(item).ToLower() != ".png")
                                continue;
                            var p = new PictureBox();
                            p.ImageLocation = item;
                            p.Load();
                            p.Width = p.Image.Width;
                            p.Height = p.Image.Height;
                            picGroup.Controls.Add(p);
                        }
                    }
                }
            }
        }

        void runCalc(object sender, DoWorkEventArgs args)
        {
            try
            {
                if (rSimpleTiled.Checked)
                    model = new SimpleTiledModel(sName.Text, stSubset.Text, (int)sWidth.Value, (int)sHeight.Value, sPeriodic.Checked, stBlack.Checked);
                else if (rOverlapping.Checked)
                    model = new OverlappingModel(sName.Text, (int)oN.Value, (int)sWidth.Value, (int)sHeight.Value, oPeriodicInput.Checked, sPeriodic.Checked, (int)oSymmetry.Value, (int)oGround.Value);
                else
                    throw new NotImplementedException();
            }
            catch (Exception e)
            {
                log($"There was an error in your settings, aborting. ({e.ToString()})");
                return;
            }
            int seed = (int)numSeed.Value;

            for (int k = 0; k < sRetries.Value; k++)
            {
                bool finished = false;
                try
                {
                    finished = model.Run(seed, (int)sLimit.Value);
                }
                catch (Exception e)
                {
                    if (e is OutOfMemoryException)
                    {
                        log("Out of memory exception was thrown, try decreasing image size! Aborting.");
                        return;
                    }
                    else
                        log($"Exception was thrown, retrying. ({e.ToString()})");
                }

                if (finished)
                {
                    log("Finished");
                    img = model.Graphics();
                    outstr = (model is SimpleTiledModel && sTextOutput.Checked) ? (model as SimpleTiledModel).TextOutput() : "";

                    break;
                }

                if (worker.CancellationPending)
                {
                    log("Cancelled");
                    return;
                }

                if (k + 1 == sRetries.Value)
                    log("Contradiction, retry limit reached, aborting.");
                else
                {
                    seed = random.Next();
                    log("Contradiction, retrying with random seed: " + seed);
                }

            }
        }
    }

    public class WaveFunctionSample
    {
        public XElement Data { get; private set; }
        public override string ToString() => Data.Get<string>("name");
        public WaveFunctionSample(XElement data) => Data = data;
    }
}