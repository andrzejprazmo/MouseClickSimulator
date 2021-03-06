namespace MouseClickSimulator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.testServerButton = new System.Windows.Forms.Button();
            this.ntpServerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lockMouseMoveCheckbox = new System.Windows.Forms.CheckBox();
            this.setPointerButton = new System.Windows.Forms.Button();
            this.testPointerButton = new System.Windows.Forms.Button();
            this.mouseYControl = new System.Windows.Forms.NumericUpDown();
            this.mouseXControl = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.precisionControl = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.executionMilisecondsControl = new System.Windows.Forms.NumericUpDown();
            this.executionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.executionWorker = new System.ComponentModel.BackgroundWorker();
            this.startButton = new System.Windows.Forms.Button();
            this.mousePositionTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripFinalTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.formDataBindings = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouseYControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouseXControl)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.precisionControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.executionMilisecondsControl)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formDataBindings)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.testServerButton);
            this.groupBox1.Controls.Add(this.ntpServerTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Synchronizacja czasu";
            // 
            // testServerButton
            // 
            this.testServerButton.Location = new System.Drawing.Point(331, 19);
            this.testServerButton.Name = "testServerButton";
            this.testServerButton.Size = new System.Drawing.Size(96, 23);
            this.testServerButton.TabIndex = 10;
            this.testServerButton.Text = "Test serwera";
            this.testServerButton.UseVisualStyleBackColor = true;
            this.testServerButton.Click += new System.EventHandler(this.testServerButton_Click);
            // 
            // ntpServerTextBox
            // 
            this.ntpServerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formDataBindings, "TimeServer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ntpServerTextBox.Location = new System.Drawing.Point(98, 20);
            this.ntpServerTextBox.Name = "ntpServerTextBox";
            this.ntpServerTextBox.Size = new System.Drawing.Size(227, 20);
            this.ntpServerTextBox.TabIndex = 1;
            this.ntpServerTextBox.Text = "ntp.ubuntu.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serwer czasu:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lockMouseMoveCheckbox);
            this.groupBox2.Controls.Add(this.setPointerButton);
            this.groupBox2.Controls.Add(this.testPointerButton);
            this.groupBox2.Controls.Add(this.mouseYControl);
            this.groupBox2.Controls.Add(this.mouseXControl);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pozycja myszy";
            // 
            // lockMouseMoveCheckbox
            // 
            this.lockMouseMoveCheckbox.AutoSize = true;
            this.lockMouseMoveCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.formDataBindings, "MovePointer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lockMouseMoveCheckbox.Location = new System.Drawing.Point(19, 25);
            this.lockMouseMoveCheckbox.Name = "lockMouseMoveCheckbox";
            this.lockMouseMoveCheckbox.Size = new System.Drawing.Size(142, 17);
            this.lockMouseMoveCheckbox.TabIndex = 10;
            this.lockMouseMoveCheckbox.Text = "Przesuń wskaźnik myszy";
            this.lockMouseMoveCheckbox.UseVisualStyleBackColor = true;
            // 
            // setPointerButton
            // 
            this.setPointerButton.Location = new System.Drawing.Point(233, 50);
            this.setPointerButton.Name = "setPointerButton";
            this.setPointerButton.Size = new System.Drawing.Size(96, 23);
            this.setPointerButton.TabIndex = 9;
            this.setPointerButton.Text = "Ustaw wskaźnik";
            this.setPointerButton.UseVisualStyleBackColor = true;
            this.setPointerButton.Click += new System.EventHandler(this.setPointerButton_Click);
            // 
            // testPointerButton
            // 
            this.testPointerButton.Location = new System.Drawing.Point(335, 50);
            this.testPointerButton.Name = "testPointerButton";
            this.testPointerButton.Size = new System.Drawing.Size(96, 23);
            this.testPointerButton.TabIndex = 8;
            this.testPointerButton.Text = "Testuj wskaźnik";
            this.testPointerButton.UseVisualStyleBackColor = true;
            this.testPointerButton.Click += new System.EventHandler(this.testPointerButton_Click);
            // 
            // mouseYControl
            // 
            this.mouseYControl.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.formDataBindings, "MouseY", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mouseYControl.Location = new System.Drawing.Point(130, 53);
            this.mouseYControl.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.mouseYControl.Name = "mouseYControl";
            this.mouseYControl.Size = new System.Drawing.Size(53, 20);
            this.mouseYControl.TabIndex = 7;
            // 
            // mouseXControl
            // 
            this.mouseXControl.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.formDataBindings, "MouseX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mouseXControl.Location = new System.Drawing.Point(41, 53);
            this.mouseXControl.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.mouseXControl.Name = "mouseXControl";
            this.mouseXControl.Size = new System.Drawing.Size(53, 20);
            this.mouseXControl.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "X:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.precisionControl);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.executionMilisecondsControl);
            this.groupBox3.Controls.Add(this.executionDateTimePicker);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 88);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Odliczanie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "milisekund";
            // 
            // precisionControl
            // 
            this.precisionControl.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.formDataBindings, "Tick", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.precisionControl.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.precisionControl.Location = new System.Drawing.Point(104, 58);
            this.precisionControl.Maximum = new decimal(new int[] {
            990,
            0,
            0,
            0});
            this.precisionControl.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.precisionControl.Name = "precisionControl";
            this.precisionControl.Size = new System.Drawing.Size(53, 20);
            this.precisionControl.TabIndex = 10;
            this.precisionControl.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dokładność:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "milisekundy";
            // 
            // executionMilisecondsControl
            // 
            this.executionMilisecondsControl.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.formDataBindings, "ExecutionMiliseconds", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.executionMilisecondsControl.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.executionMilisecondsControl.Location = new System.Drawing.Point(246, 32);
            this.executionMilisecondsControl.Maximum = new decimal(new int[] {
            990,
            0,
            0,
            0});
            this.executionMilisecondsControl.Name = "executionMilisecondsControl";
            this.executionMilisecondsControl.Size = new System.Drawing.Size(58, 20);
            this.executionMilisecondsControl.TabIndex = 10;
            // 
            // executionDateTimePicker
            // 
            this.executionDateTimePicker.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            this.executionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.formDataBindings, "ExecutionDateTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.executionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.executionDateTimePicker.Location = new System.Drawing.Point(104, 32);
            this.executionDateTimePicker.Name = "executionDateTimePicker";
            this.executionDateTimePicker.Size = new System.Drawing.Size(136, 20);
            this.executionDateTimePicker.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data wykonania:";
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentTimeLabel.Location = new System.Drawing.Point(339, 183);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(104, 20);
            this.currentTimeLabel.TabIndex = 3;
            this.currentTimeLabel.Text = "00:00:00:00";
            // 
            // executionWorker
            // 
            this.executionWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.executionWorker_DoWork);
            this.executionWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.executionWorker_RunWorkerCompleted);
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(333, 225);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(110, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // mousePositionTimer
            // 
            this.mousePositionTimer.Tick += new System.EventHandler(this.mousePositionTimer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFinalTimeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 267);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(461, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripFinalTimeLabel
            // 
            this.toolStripFinalTimeLabel.Name = "toolStripFinalTimeLabel";
            this.toolStripFinalTimeLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // formDataBindings
            // 
            this.formDataBindings.DataSource = typeof(MouseClickSimulator.FormData);
            this.formDataBindings.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.formDataBindings_BindingComplete);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 289);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Symulator kliknięcia myszy";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouseYControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouseXControl)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.precisionControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.executionMilisecondsControl)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formDataBindings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ntpServerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button testPointerButton;
        private System.Windows.Forms.NumericUpDown mouseYControl;
        private System.Windows.Forms.NumericUpDown mouseXControl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker executionDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.BindingSource formDataBindings;
        private System.ComponentModel.BackgroundWorker executionWorker;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button setPointerButton;
        private System.Windows.Forms.Timer mousePositionTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown executionMilisecondsControl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripFinalTimeLabel;
        private System.Windows.Forms.Button testServerButton;
        private System.Windows.Forms.NumericUpDown precisionControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox lockMouseMoveCheckbox;
    }
}

