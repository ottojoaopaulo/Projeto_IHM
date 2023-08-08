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
        public Form1()
        {
            InitializeComponent();
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
    }
}
