using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPD_3303S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComPort.ComPortLoad(ref this.cmbComPort,"COM1");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonConnect.Text == "Connect")
                {
                    if (serialPort1.IsOpen)
                    {
                        MessageBox.Show(this.cmbComPort.SelectedText + " is already open."
                            , "Error"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Error);
                    }
                    else
                    {
                        System.Text.RegularExpressions.Match mc;

                        mc = System.Text.RegularExpressions.Regex.Match(this.cmbComPort.SelectedItem.ToString(), @"(COM[1-9][0-9]?[0-9]?)");
                        if (mc.Success)
                        {
                            this.serialPort1.PortName = mc.Value;
                            this.serialPort1.BaudRate = 9600;
                            this.serialPort1.Parity = System.IO.Ports.Parity.None;
                            this.serialPort1.DataBits = 8;
                            this.serialPort1.StopBits = System.IO.Ports.StopBits.One;
                            this.serialPort1.Handshake = System.IO.Ports.Handshake.None;
                            this.serialPort1.Encoding = Encoding.ASCII;
                            this.serialPort1.NewLine = "\n";
                            this.serialPort1.Open();
                            this.buttonConnect.Text = "Disconnect";
                            this.cmbComPort.Enabled = false;
                        }
                    }
                }
                else
                {
                    serialPort1.Close();
                    this.buttonConnect.Text = "Connect";
                    this.cmbComPort.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonOutput_CheckedChanged(object sender, EventArgs e)
        {
            string command = "";
            int onf = 0;
            RadioButton radio = (RadioButton)sender;
            if (((radio.Name == "radioButtonOutputOff") && (radio.Checked == false))
                || ((radio.Name == "radioButtonOutputOn") && (radio.Checked == true))
                )
            {
                onf = 1;
            }
            else
            {
                onf = 0;
            }
            command = String.Format("OUT{0}", onf);
            try
            {
                this.serialPort1.WriteLine(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }
    }
}
