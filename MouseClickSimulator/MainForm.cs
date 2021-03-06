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

        private bool formClosePending = false;

        private bool setPointerProcessRunning = false;
        public MainForm()
        {
            InitializeComponent();
            Data = new FormData
            {
                TimeServer = Properties.Settings.Default.TimeServer,
                MouseX = Properties.Settings.Default.MouseX,
                MouseY = Properties.Settings.Default.MouseY,
                Tick = Properties.Settings.Default.Tick,
                MovePointer = true,
            };
            formDataBindings.DataSource = Data;
        }

        private void testPointerButton_Click(object sender, EventArgs e)
        {
            Processor.SetPointer(Data);
        }

        private void formDataBindings_BindingComplete(object sender, BindingCompleteEventArgs e)
            {
            Properties.Settings.Default.TimeServer = Data.TimeServer;
            Properties.Settings.Default.MouseX = Data.MouseX;
            Properties.Settings.Default.MouseY = Data.MouseY;
            Properties.Settings.Default.Tick = Data.Tick;
            Properties.Settings.Default.Save();
            startButton.Enabled = !string.IsNullOrEmpty(Data.TimeServer) && Data.ExecutionDateTime > DateTime.Now;
            mouseXControl.Enabled = Data.MovePointer;
            mouseYControl.Enabled = Data.MovePointer;
            setPointerButton.Enabled = Data.MovePointer;
            testPointerButton.Enabled = Data.MovePointer;
        }

        private void synchronizeButton_Click(object sender, EventArgs e)
        {
            Synchronizer.Synchronize(Data.TimeServer);
        }

        private void executionWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var data = e.Argument as FormData;
            int tick = data.Tick;
            data.Running = true;
            toolStripFinalTimeLabel.Text = "Rozpoczęto odliczanie...";
            NTPClient client;
            try
            {
                client = new NTPClient(data.TimeServer);
                client.Connect(true);
                var executionDateTime = new DateTime(data.ExecutionDateTime.Year
                    , data.ExecutionDateTime.Month
                    , data.ExecutionDateTime.Day
                    , data.ExecutionDateTime.Hour
                    , data.ExecutionDateTime.Minute
                    , data.ExecutionDateTime.Second
                    , data.ExecutionMiliseconds);
                var originalTimeStamp = client.ReceiveTimestamp;
                if (executionDateTime > originalTimeStamp)
                {
                    do
                    {
                        startButton.Enabled = true;
                        var timeDiff = executionDateTime - DateTime.Now;
                        currentTimeLabel.Text = string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D2}", timeDiff.Days, timeDiff.Hours, timeDiff.Minutes, timeDiff.Seconds);
                        if (timeDiff.TotalMilliseconds <= 0)
                        {
                            Processor.LeftMouseClick(data);
                            break;
                        }
                        Thread.Sleep(tick);
                    } while (data.Running);
                    currentTimeLabel.Text = "00:00:00:00";
                    toolStripFinalTimeLabel.Text = $"Czas kliknięcia: {DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss.fff")}";
                    e.Cancel = true;
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
            EnableControls(true);
            if (formClosePending)
            {
                Close();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!Data.Running)
            {
                startButton.Text = "Przerwij";
                startButton.Enabled = false;
                EnableControls(false);
                executionWorker.RunWorkerAsync(Data);
            }
            else
            {
                Data.Running = false;
            }
        }

        private void setPointerButton_Click(object sender, EventArgs e)
        {
            setPointerProcessRunning = true;
            setPointerButton.Enabled = false;
            setPointerButton.Text = "Naciśnij Esc";
            mousePositionTimer.Start();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    setPointerProcessRunning = false;
                    setPointerButton.Enabled = true;
                    setPointerButton.Text = "Ustaw wskaźnik";
                    mousePositionTimer.Stop();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void mousePositionTimer_Tick(object sender, EventArgs e)
        {
            if (setPointerProcessRunning)
            {
                mouseXControl.Value = Cursor.Position.X;
                mouseYControl.Value = Cursor.Position.Y;
            }
        }

        private void testServerButton_Click(object sender, EventArgs e)
        {
            var client = new NTPClient(Data.TimeServer);
            client.Connect(false);
            var serverTime = client.ReceiveTimestamp;
            var now = DateTime.Now;
            string message = $"Server: {serverTime.ToString("dd-MM-yyyy HH:mm.ss.fff")} \n Local: {now.ToString("dd-MM-yyyy HH:mm.ss.fff")}";
            MessageBox.Show(message);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (executionWorker.IsBusy)
            {
                Data.Running = false;
                e.Cancel = true;
                formClosePending = true;
            }
        }

        private void EnableControls(bool enabled = true)
        {
            ntpServerTextBox.Enabled = enabled;
            testServerButton.Enabled = enabled;
            lockMouseMoveCheckbox.Enabled = enabled;
            mouseXControl.Enabled = enabled;
            mouseYControl.Enabled = enabled;
            setPointerButton.Enabled = enabled;
            testPointerButton.Enabled= enabled;
            executionDateTimePicker.Enabled = enabled;
            executionMilisecondsControl.Enabled = enabled;
            precisionControl.Enabled = enabled;
        }
    }
}
