namespace Arduino_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnBlue = new Button();
            btnGreen = new Button();
            btnRed = new Button();
            groupBox2 = new GroupBox();
            labelSlider = new Label();
            servoSlider = new TrackBar();
            Message = new GroupBox();
            btnClear = new Button();
            btnSend = new Button();
            textBox1 = new TextBox();
            groupBox3 = new GroupBox();
            sensorProgressBar = new CircularProgressBar.CircularProgressBar();
            groupBox4 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            btnOpen = new Button();
            cBoxBaud = new ComboBox();
            cBoxPort = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)servoSlider).BeginInit();
            Message.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBlue);
            groupBox1.Controls.Add(btnGreen);
            groupBox1.Controls.Add(btnRed);
            groupBox1.Location = new Point(21, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 126);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "LEDs";
            // 
            // btnBlue
            // 
            btnBlue.Image = Properties.Resources.ledBlueOff;
            btnBlue.Location = new Point(264, 22);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(100, 90);
            btnBlue.TabIndex = 3;
            btnBlue.UseVisualStyleBackColor = true;
            btnBlue.Click += btnBlue_Click;
            // 
            // btnGreen
            // 
            btnGreen.Image = Properties.Resources.ledGreenOff;
            btnGreen.Location = new Point(134, 22);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(100, 90);
            btnGreen.TabIndex = 2;
            btnGreen.UseVisualStyleBackColor = true;
            btnGreen.Click += btnGreen_Click;
            // 
            // btnRed
            // 
            btnRed.Image = Properties.Resources.ledRedOff;
            btnRed.Location = new Point(6, 22);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(100, 90);
            btnRed.TabIndex = 1;
            btnRed.UseVisualStyleBackColor = true;
            btnRed.Click += btnRed_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelSlider);
            groupBox2.Controls.Add(servoSlider);
            groupBox2.Location = new Point(21, 247);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(364, 85);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Servo";
            // 
            // labelSlider
            // 
            labelSlider.AutoSize = true;
            labelSlider.Location = new Point(175, 67);
            labelSlider.Name = "labelSlider";
            labelSlider.Size = new Size(13, 15);
            labelSlider.TabIndex = 1;
            labelSlider.Text = "0";
            // 
            // servoSlider
            // 
            servoSlider.Location = new Point(6, 22);
            servoSlider.Maximum = 180;
            servoSlider.Name = "servoSlider";
            servoSlider.Size = new Size(352, 45);
            servoSlider.TabIndex = 0;
            servoSlider.Scroll += servoSlider_Scroll;
            // 
            // Message
            // 
            Message.Controls.Add(btnClear);
            Message.Controls.Add(btnSend);
            Message.Controls.Add(textBox1);
            Message.Location = new Point(21, 338);
            Message.Name = "Message";
            Message.Size = new Size(364, 264);
            Message.TabIndex = 2;
            Message.TabStop = false;
            Message.Text = "Message";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(139, 203);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 50);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(245, 203);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(100, 50);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 175);
            textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(sensorProgressBar);
            groupBox3.Location = new Point(397, 115);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(167, 126);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sensor";
            // 
            // sensorProgressBar
            // 
            sensorProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            sensorProgressBar.AnimationSpeed = 500;
            sensorProgressBar.BackColor = Color.Transparent;
            sensorProgressBar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sensorProgressBar.ForeColor = Color.FromArgb(64, 64, 64);
            sensorProgressBar.InnerColor = Color.FromArgb(224, 224, 224);
            sensorProgressBar.InnerMargin = 2;
            sensorProgressBar.InnerWidth = -1;
            sensorProgressBar.Location = new Point(35, 20);
            sensorProgressBar.MarqueeAnimationSpeed = 2000;
            sensorProgressBar.Name = "sensorProgressBar";
            sensorProgressBar.OuterColor = Color.Gray;
            sensorProgressBar.OuterMargin = -25;
            sensorProgressBar.OuterWidth = 25;
            sensorProgressBar.ProgressColor = Color.FromArgb(255, 128, 0);
            sensorProgressBar.ProgressWidth = 15;
            sensorProgressBar.SecondaryFont = new Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            sensorProgressBar.Size = new Size(100, 100);
            sensorProgressBar.StartAngle = 270;
            sensorProgressBar.SubscriptColor = Color.FromArgb(166, 166, 166);
            sensorProgressBar.SubscriptMargin = new Padding(10, -35, 0, 0);
            sensorProgressBar.SubscriptText = "";
            sensorProgressBar.SuperscriptColor = Color.FromArgb(166, 166, 166);
            sensorProgressBar.SuperscriptMargin = new Padding(10, 35, 0, 0);
            sensorProgressBar.SuperscriptText = "";
            sensorProgressBar.TabIndex = 4;
            sensorProgressBar.Text = "0";
            sensorProgressBar.TextMargin = new Padding(0);
            sensorProgressBar.Value = 68;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(btnOpen);
            groupBox4.Controls.Add(cBoxBaud);
            groupBox4.Controls.Add(cBoxPort);
            groupBox4.Location = new Point(21, 21);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(543, 88);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Setting";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 27);
            label1.Name = "label1";
            label1.Size = new Size(42, 18);
            label1.TabIndex = 3;
            label1.Text = "Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 56);
            label2.Name = "label2";
            label2.Size = new Size(92, 18);
            label2.TabIndex = 4;
            label2.Text = "Baud Rate";
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(457, 21);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 53);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click_1;
            // 
            // cBoxBaud
            // 
            cBoxBaud.FormattingEnabled = true;
            cBoxBaud.Location = new Point(245, 51);
            cBoxBaud.Name = "cBoxBaud";
            cBoxBaud.Size = new Size(206, 23);
            cBoxBaud.TabIndex = 1;
            // 
            // cBoxPort
            // 
            cBoxPort.FormattingEnabled = true;
            cBoxPort.Location = new Point(245, 22);
            cBoxPort.Name = "cBoxPort";
            cBoxPort.Size = new Size(206, 23);
            cBoxPort.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 621);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(Message);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arduino GUI";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)servoSlider).EndInit();
            Message.ResumeLayout(false);
            Message.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnBlue;
        private Button btnGreen;
        private Button btnRed;
        private GroupBox groupBox2;
        private Label labelSlider;
        private TrackBar servoSlider;
        private GroupBox Message;
        private Button btnClear;
        private Button btnSend;
        private TextBox textBox1;
        private GroupBox groupBox3;
        private CircularProgressBar.CircularProgressBar sensorProgressBar;
        private GroupBox groupBox4;
        private Button btnOpen;
        private ComboBox cBoxBaud;
        private ComboBox cBoxPort;
        private Label label2;
        private Label label1;
        private Button btnConnnect;
        private TextBox txtBoxIP;
        private TextBox txtBoxPort;
    }
}