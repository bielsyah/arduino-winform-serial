using System.IO.Ports;
using System.Xml.Linq;

namespace Arduino_GUI
{
    public partial class Form1 : Form
    {

        private bool isRedLEDPressed = false;
        private bool isGreenLEDPressed = false;
        private bool isBlueLEDPressed = false;

        private int[] baudRate = { 110, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000, 256000 };
        static private SerialPort port;

        string imgPath = "C:\\Images\\";

        public Form1()
        {
            InitializeComponent();

            sensorProgressBar.Value = 0;
            sensorProgressBar.Minimum = 0;
            sensorProgressBar.Maximum = 180;

            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                cBoxPort.Items.Add(port);
            }
            foreach (int baudRate in baudRate)
            {
                cBoxBaud.Items.Add(baudRate.ToString());
            }

            btnOpen.Enabled = false;
            btnRed.Enabled = false;
            btnGreen.Enabled = false;
            btnBlue.Enabled = false;
            btnSend.Enabled = false;
            btnClear.Enabled = false;
            textBox1.Enabled = false;
            servoSlider.Enabled = false;

            cBoxPort.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cBoxBaud.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

        }
        private void ComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cBoxPort.SelectedItem != null && cBoxBaud.SelectedItem != null)
            {
                btnOpen.Enabled = true;
            }
        }
        private void btnRed_Click(object sender, EventArgs e)
        {
            try
            {
                if (isRedLEDPressed)
                {
                    sendData(btnRed, "ROFF", "ledRedOff.png");
                }
                else
                {
                    sendData(btnRed, "RON", "ledRedOn.png");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            isRedLEDPressed = !isRedLEDPressed;
        }
        private void btnGreen_Click(object sender, EventArgs e)
        {
            try
            {
                if (isGreenLEDPressed)
                {
                    sendData(btnGreen, "GOFF", "ledGreenOff.png");
                }
                else
                {
                    sendData(btnGreen, "GON", "ledGreenOn.png");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            isGreenLEDPressed = !isGreenLEDPressed;
        }
        private void btnBlue_Click(object sender, EventArgs e)
        {
            try
            {
                if (isBlueLEDPressed)
                {
                    sendData(btnBlue, "BOFF", "ledBlueOff.png");
                }
                else
                {
                    sendData(btnBlue, "BON", "ledBlueOn.png");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            isBlueLEDPressed = !isBlueLEDPressed;
        }

        private void servoSlider_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;
            int value = trackBar.Value;
            port.Write(value.ToString() + "\n");
            labelSlider.Text = value.ToString();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            port.Write(textBox1.Text.ToString());
            textBox1.Text = "";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            port.Write("clr");
        }
        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            port = new SerialPort();
            port.PortName = cBoxPort.SelectedItem.ToString();
            port.BaudRate = Convert.ToInt32(cBoxBaud.SelectedItem);
            port.DtrEnable = true;

            port.DataReceived += myData;
            port.Open();

            if (port.IsOpen)
            {
                MessageBox.Show("Connected!");
                btnRed.Enabled = true;
                btnBlue.Enabled = true;
                btnGreen.Enabled = true;
                btnSend.Enabled = true;
                btnClear.Enabled = true;
                textBox1.Enabled = true;
                servoSlider.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed to Connnect!");
            }

        }
        private void myData(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort port = (SerialPort)sender;
            string data = port.ReadLine();

            if (Form.ActiveForm is Form1 form)
            {
                form.Invoke((MethodInvoker)delegate
                {
                    form.sensorProgressBar.Value = Convert.ToInt32(data);
                    form.sensorProgressBar.Text = data;
                });
            }
        }
        private void sendData(Button btn, string data, string img)
        {
            Image image = Image.FromFile(imgPath + img);

            btn.Image = image;
            btn.ImageAlign = ContentAlignment.MiddleCenter;
            port.Write(data);
        }
    }
}