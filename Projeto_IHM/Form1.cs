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
            //configuracao para identificar as portas seriais
            #region Config_Port
            string[] valoresPort = SerialPort.GetPortNames();
            for (int i = 0; i < valoresPort.Length; i++)
            {
                cbBoxPort.Items.Add(valoresPort[i]);
            }


            #endregion

        }
    }
}
