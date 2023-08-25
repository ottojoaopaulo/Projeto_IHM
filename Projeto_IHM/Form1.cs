using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;//adiciona porta serial

namespace Projeto_IHM
{
    public partial class Form1 : Form
    {
        delegate void funcaoRecepcao();

        public Form1()
            //comando de interupcao do microcontrolador
        {
            InitializeComponent();

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }

        void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            funcaoRecepcao recepcaodelegate = new funcaoRecepcao(RecepcaoSerial);
            Invoke(recepcaodelegate);
        }

        String chtxt = null, str = null;
        public void RecepcaoSerial()
        {

            chtxt += serialPort1.ReadExisting();
            txtRec.Text += chtxt;
            str += chtxt;
            chtxt = null;
            //01234567
            //texto [LeD1ON] ou [LeD1OF]
            //texto [A10000]


            if (str.Substring(0, 1).Equals("["))
            {
                if (str.Length >= 8)
                {
                    if (str.Substring(1, 1).Equals("L") &&
                        str.Substring(2, 1).Equals("e") &&
                        str.Substring(3, 1).Equals("D") &&
                        str.Substring(5, 1).Equals("O") &&
                        str.Substring(7, 1).Equals("]"))
                    {
                        if (str.Substring(6, 1).Equals("N"))
                        {
                            switch (str.Substring(4, 1))
                            {
                                case "1":
                                    pnLed1.BackColor = Color.Red;
                                    break;
                                case "2":
                                    pnLed2.BackColor = Color.Red;
                                    break;
                            }
                        }
                        else
                        {
                            if (str.Substring(6, 1).Equals("F"))
                            {
                                switch (str.Substring(4, 1))
                                {
                                    case "1":
                                        pnLed1.BackColor = Color.Maroon;
                                        break;
                                    case "2":
                                        pnLed2.BackColor = Color.Maroon;
                                        break;
                                }
                            }
                        }
                        str = null;
                    }
                    else
                    {
                        if (str.Substring(1, 1).Equals("A") && str.Substring(7, 1).Equals("]"))
                        {
                            if (str.Substring(2, 1).Equals("1"))
                            {
                                lblSensor1.Text = str.Substring(3, 4);
                                pgBar1.Value = int.Parse(str.Substring(3, 4));
                            }
                            else
                            {
                                if (str.Substring(2, 1).Equals("2"))
                                {
                                    lblSensor2.Text = str.Substring(3, 4);
                                    pgBar2.Value = int.Parse(str.Substring(3, 4));
                                }
                            }
                            str = null;
                        }
                    }
                    str = null;
                }
            }
            else
            {
                str = null;
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //comando do botao Exit
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //configuracao das portas COMPort
            #region Config_Port
            string[] valoresPort = SerialPort.GetPortNames();
            for (int i = 0; i < valoresPort.Length; i++)
            {
                cbBoxPort.Items.Add(valoresPort[i]);
            }
            cbBoxPort.Text = "COM1";
            #endregion

            //configuracao da porta BaudRate
            #region Config_Baud
            int[] valoresBaud = { 2400, 4800, 9600, 19200, 57600, 115200 };
            for (int i = 0; i < valoresBaud.Length; i++)
            {
                cbBoxBaud.Items.Add(valoresBaud[i].ToString());
            }
            cbBoxBaud.Text = "2400";
            #endregion

            //Configuracao para DataBits
            #region Config_Data
            cbBoxData.Items.Add("7");
            cbBoxData.Items.Add("8");
            cbBoxData.Text = "8";
            #endregion

            //Configuracao para StopBits
            #region Config_Stop
            cbBoxStop.Items.Add("None");
            cbBoxStop.Items.Add("One");
            cbBoxStop.Items.Add("two");
            cbBoxStop.Text = "One";
            #endregion

            //Configuracao para Parity
            #region Config_Parity
            cbBoxParity.Items.Add("NONE");
            cbBoxParity.Items.Add("EVEN");
            cbBoxParity.Items.Add("COD");
            cbBoxParity.Items.Add("MARK");
            cbBoxParity.Items.Add("APACE");
            cbBoxParity.Text = "NONE";
            #endregion

        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true) serialPort1.Close();
            
            else
            
            {
                serialPort1.PortName = cbBoxPort.Text;
                serialPort1.BaudRate = int.Parse(cbBoxBaud.Text);
                serialPort1.DataBits = int.Parse(cbBoxData.Text);
                serialPort1.StopBits = (StopBits)(cbBoxStop.SelectedIndex);
                serialPort1.Parity = (Parity)(cbBoxParity.SelectedIndex);
            }
            //Tratamento de erro para conexao
            try
            {
                serialPort1.Open();
                //Quando conecta os campos sao desativados
                btnCon.Enabled = false;
                btnDes.Enabled = true;
                btnExit.Enabled = false;
                cbBoxPort.Enabled = false;
                cbBoxBaud.Enabled = false;
                cbBoxData.Enabled = false;
                cbBoxStop.Enabled = false;
                cbBoxParity.Enabled = false;
                pnMensagen.BackColor = Color.Green;
                lblMsg.Text = "Close Port";
                
            }
            catch
            {
                MessageBox.Show("Erro de Comunicacao com a porta!");
                btnCon.Enabled = true;
                btnDes.Enabled = false;
                btnExit.Enabled = true;
                cbBoxPort.Enabled = true;
                cbBoxBaud.Enabled = true;
                cbBoxData.Enabled = true;
                cbBoxStop.Enabled = true;
                cbBoxParity.Enabled = true;
                pnMensagen.BackColor = Color.Red;
                lblMsg.Text = "Open Port";

            }
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                btnCon.Enabled = true;
                btnDes.Enabled = false;
                btnExit.Enabled = true;
                cbBoxPort.Enabled = true;
                cbBoxBaud.Enabled = true;
                cbBoxData.Enabled = true;
                cbBoxStop.Enabled = true;
                cbBoxParity.Enabled = true;
                pnMensagen.BackColor = Color.Red;
                lblMsg.Text = "Open Port";
                pgBar1.Value = 0;
                pgBar2.Value = 0;
                lblSensor1.Text = "0000";
                lblSensor2.Text = "0000";
                txtRec.Text = null;

            }
            catch
            {
                MessageBox.Show("Erro de Comunicacao com a porta!");
                btnCon.Enabled = false;
                btnDes.Enabled = true;
                btnExit.Enabled = false;
                cbBoxPort.Enabled = false;
                cbBoxBaud.Enabled = false;
                cbBoxData.Enabled = false;
                cbBoxStop.Enabled = false;
                cbBoxParity.Enabled = false;
                pnMensagen.BackColor = Color.Green;
                lblMsg.Text = "Close Port";
            }
        }

        private void txtEnviar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                if (chBoxEnviar.Checked)
                {
                    serialPort1.Write(txtEnviar.Text + "\r");
                }
                else
                {
                    serialPort1.Write(txtEnviar.Text);
                }
                txtEnviar.Text = null;
            }
            else
            {
                MessageBox.Show("Erro de Comunicacao com a porta!");
            }
        }
        //texto [Botao1]
        private void btnBotao1_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == true) serialPort1.Write("[Botao1]");
        }

        private void btnBotao2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true) serialPort1.Write("[Botao2]");
        }
        //texto [Botao2]
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblS1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BarPWM_Scroll(object sender, EventArgs e)
        {
            int valorPWM = BarPWM.Value * 50;
            serialPort1.Write("[PWM" + valorPWM.ToString() + "]");
        }

        //comando para limpar area de recepcao de dados
        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtRec.Text = null;
            
        }
    }
}
