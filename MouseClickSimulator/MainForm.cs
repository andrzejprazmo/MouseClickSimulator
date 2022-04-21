using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClickSimulator
{
    public partial class MainForm : Form
    {
        public FormData Data { get; set; }
        public MouseClickProcessor Processor { get; set; } = new MouseClickProcessor();
        public MainForm()
        {
            InitializeComponent();
            Data = new FormData
            {
                TimeServer = Properties.Settings.Default.TimeServer,
                MouseX = Properties.Settings.Default.MouseX,
                MouseY = Properties.Settings.Default.MouseY,
            };
            formDataBindings.DataSource = Data;
        }

        private void setPointerButton_Click(object sender, EventArgs e)
        {
            Processor.SetPointer(Data);
        }

        private void formDataBindings_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            Properties.Settings.Default.TimeServer = Data.TimeServer;
            Properties.Settings.Default.MouseX = Data.MouseX;
            Properties.Settings.Default.MouseY = Data.MouseY;
            Properties.Settings.Default.Save();
            startButton.Enabled = !string.IsNullOrEmpty(Data.TimeServer) && Data.ExecutionDateTime > DateTime.Now;
        }

        private void synchronizeButton_Click(object sender, EventArgs e)
        {
            Synchronizer.Synchronize(Data.TimeServer);
        }

        private void executionWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var data = e.Argument as FormData;
            data.Running = true;
            NTPClient client;
            try
            {
                client = new NTPClient(data.TimeServer);
                client.Connect(false);
                if (data.ExecutionDateTime > client.ReferenceTimestamp)
                {
                    var timeDiff = data.ExecutionDateTime - client.OriginateTimestamp;
                    do
                    {
                        currentTimeLabel.Text = string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D2}", timeDiff.Days, timeDiff.Hours, timeDiff.Minutes, timeDiff.Seconds);
                        timeDiff = timeDiff.Subtract(new TimeSpan(0, 0, 0, 0, 100));
                        if (timeDiff.TotalMilliseconds <= 0)
                        {
                            Processor.LeftMouseClick(data);
                            break;
                        }
                        Thread.Sleep(100);
                    } while (data.Running);
                    currentTimeLabel.Text = "00:00:00:00";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void executionWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            startButton.Text = "Start";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!Data.Running)
            {
                executionWorker.RunWorkerAsync(Data);
                startButton.Text = "Przerwij";
            }
            else
            {
                Data.Running = false;
            }
        }
    }
}
