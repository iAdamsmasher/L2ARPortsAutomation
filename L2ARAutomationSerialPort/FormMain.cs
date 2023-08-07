using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void buttonOpenDrawer_Click(object sender, EventArgs e)
        {
            sendComand("OPEN");
        }
        private void sendComand(string cmd)
        {

            serialPort = new SerialPort(comboBoxPorts.Text);

        }
    }
}
