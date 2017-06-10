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
            ComPort.ComPortLoad(ref cmbComPort, "COM1");

        }

        private void Send(string command)
        {
            try
            {
                serialPort1.WriteLine(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private string Receive()
        {
            string data = "";

            if (serialPort1 != null)
            {
                try
                {
                    data = serialPort1.ReadLine();
                    data = data.Replace('\r', '\0');
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
            return data;
        }
        private void LoadOutputCurrent( object obj, int ch)
        {
            string command = String.Format("IOUT{0}?", ch);
            Send(command);
            string data = Receive();
            data = data.Replace('A', '\0');
            ((TextBox)obj).Text = data;
        }

        private void LoadCurrent( object obj, int ch)
        {
            string command = String.Format("ISET{0}?", ch);
            Send(command);
            string data = Receive();
            data = data.Replace('A', '\0');
            ((NumericUpDown)obj).Value = (decimal)double.Parse(data);
        }

        private void LoadVoltage(object obj, int ch)
        {
            string command = String.Format("VSET{0}?", ch);
            Send(command);
            string data = Receive();
            data = data.Replace('V', '\0');
            ((NumericUpDown)obj).Value = (decimal)double.Parse(data);
        }

        private void EnableSettings( bool enable )
        {
            numericUpDownIch1.Enabled = enable;
            numericUpDownIch2.Enabled = enable;
            numericUpDownVch1.Enabled = enable;
            numericUpDownVch2.Enabled = enable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonConnect.Text == "Connect")
                {
                    if (serialPort1.IsOpen)
                    {
                        MessageBox.Show(cmbComPort.SelectedText + " is already open."
                            , "Error"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Error);
                    }
                    else
                    {
                        System.Text.RegularExpressions.Match mc;

                        mc = System.Text.RegularExpressions.Regex.Match(cmbComPort.SelectedItem.ToString(), @"(COM[1-9][0-9]?[0-9]?)");
                        if (mc.Success)
                        {
                            serialPort1.PortName = mc.Value;
                            serialPort1.BaudRate = 9600;
                            serialPort1.Parity = System.IO.Ports.Parity.None;
                            serialPort1.DataBits = 8;
                            serialPort1.StopBits = System.IO.Ports.StopBits.One;
                            serialPort1.Handshake = System.IO.Ports.Handshake.None;
                            serialPort1.Encoding = Encoding.ASCII;
                            serialPort1.NewLine = "\n";
                            serialPort1.ReadTimeout = 3000;
                            serialPort1.WriteTimeout = 3000;
                            serialPort1.Open();
                            buttonConnect.Text = "Disconnect";
                            cmbComPort.Enabled = false;
                        }
                        // 初期値ロード
                        Send("STATUS?");
                        //MessageBox.Show( Receive() );
                        string status= Receive();
                        //                        enum Status { Ch1, Ch2, Tracking0, Tracking1, Buzzer, Output, Baud0, Baud1 };
                        // Buzzer
                        if (status[4] == '1')
                        {
                            radioButtonBeepOn.Checked = true;
                            radioButtonBeepOff.Checked = false;
                        }
                        else
                        {
                            radioButtonBeepOn.Checked = false;
                            radioButtonBeepOff.Checked = true;
                        }
                        // Output
                        if (status[5] == '1')
                        {
                            radioButtonOutputOn.Checked = true;
                            radioButtonOutputOff.Checked = false;
                            EnableSettings(false);
                        }
                        else
                        {
                            radioButtonOutputOn.Checked = false;
                            radioButtonOutputOff.Checked = true;
                            EnableSettings(true);
                        }

                        // 出力電流値(CH1)
                        LoadOutputCurrent(textBoxOutputCurrentCh1, 1);
                        // 設定電流値(CH1)
                        LoadCurrent(numericUpDownIch1, 1);
                        // 設定電圧(CH1)
                        LoadVoltage(numericUpDownVch1, 1);

                        // 出力電流値(CH2)
                        LoadOutputCurrent(textBoxOutputCurrentCh2, 2);
                        // 設定電流値(CH2)
                        LoadCurrent(numericUpDownIch2, 2);
                        // 設定電圧(CH2)
                        LoadVoltage(numericUpDownVch2, 2);
                    }
                }
                else
                {
                    serialPort1.Close();
                    buttonConnect.Text = "Connect";
                    cmbComPort.Enabled = true;
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
                EnableSettings(false);
            }
            else
            {
                onf = 0;
                EnableSettings(true);
            }
            command = String.Format("OUT{0}", onf);
            Send(command);
        }

        private void radioButtonBeep_CheckedChanged(object sender, EventArgs e)
        {
            string command = "";
            int onf = 0;
            RadioButton radio = (RadioButton)sender;
            if (((radio.Name == "radioButtonBeepOff") && (radio.Checked == false))
                || ((radio.Name == "radioButtonBeepOn") && (radio.Checked == true))
                )
            {
                onf = 1;
            }
            else
            {
                onf = 0;
            }
            command = String.Format("BEEP{0}", onf);
            Send(command);
        }

        private void numericUpDownIch1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            double data = (double)num.Value;
            string command = String.Format("ISET1:{0}",data.ToString());
            Send(command);
        }

        private void numericUpDownIch2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            double data = (double)num.Value;
            string command = String.Format("ISET2:{0}", data.ToString());
            Send(command);
        }

        private void numericUpDownVch1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            double data = (double)num.Value;
            string command = String.Format("VSET1:{0}", data.ToString());
            Send(command);
        }

        private void numericUpDownVch2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            double data = (double)num.Value;
            string command = String.Format("VSET2:{0}", data.ToString());
            Send(command);

        }

        private void buttonRefreshCurrent_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if ( btn.Name == "buttonRefreshCurrentCh1" )
            {
                LoadOutputCurrent(textBoxOutputCurrentCh1, 1);
            }
            if (btn.Name == "buttonRefreshCurrentCh2")
            {
                LoadOutputCurrent(textBoxOutputCurrentCh2, 2);
            }

        }

        private void buttonLocal_Click(object sender, EventArgs e)
        {
            Send("LOCAL");
        }
    }
}
