using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace L2ARAutomationSerialPort
{
    public partial class FormSerialPortAutomation : Form
    {
        SerialPort serialPort;


        public FormSerialPortAutomation()
        {
            InitializeComponent();
        }


        private void sendSerialComand(string serialCmd)
        {
            textBoxResult.Text += "-> Write" + Environment.NewLine;
            try
            {
                textBoxResult.Text += serialCmd + Environment.NewLine;
                Application.DoEvents();

                serialPort = new SerialPort(comboBoxPorts.Text);
                serialPort.BaudRate = int.Parse(comboBoxBoundRate.Text);
                serialPort.DataBits = int.Parse(comboBoxDataBits.Text);

                if (comboBoxStopBits.Text == "One")
                    serialPort.StopBits = StopBits.One;
                if (comboBoxStopBits.Text == "Two")
                    serialPort.StopBits = StopBits.Two;

                serialPort.Write(serialCmd);

                if (serialCmd == "STATUS")
                {
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    serialPort.Open();
                    serialPort.Close();
                }

                if (serialPort.IsOpen)
                    serialPort.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }

        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            textBoxResult.Text += "Data Received:";
            textBoxResult.Text += indata;
        }
        private void buttonOpenDrawer_Click(object sender, EventArgs e)
        {
            sendSerialComand("OPEN");
        }

        private void buttonCloseDrawer_Click(object sender, EventArgs e)
        {
            sendSerialComand("CLOSE");
        }

        private void buttonUpClip_Click(object sender, EventArgs e)
        {
            sendSerialComand("SIXON");
        }

        private void buttonDownClip_Click(object sender, EventArgs e)
        {
            sendSerialComand("SIXOFF");
        }

        private void buttonUSBIn_Click(object sender, EventArgs e)
        {
            sendSerialComand("FOURON");
        }

        private void buttonUSBOut_Click(object sender, EventArgs e)
        {
            sendSerialComand("FOUROFF");
        }

        private void buttonP3In_Click(object sender, EventArgs e)
        {
            sendSerialComand("FIVEON");
        }

        private void buttonP3Out_Click(object sender, EventArgs e)
        {
            sendSerialComand("FIVEOFF");
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            sendSerialComand("STATUS");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
        }
    }
}
