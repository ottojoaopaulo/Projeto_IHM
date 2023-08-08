namespace Projeto_IHM
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lblPort = new System.Windows.Forms.Label();
            this.cbBoxPort = new System.Windows.Forms.ComboBox();
            this.cbBoxBaud = new System.Windows.Forms.ComboBox();
            this.lblBaud = new System.Windows.Forms.Label();
            this.cbBoxData = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.cbBoxStop = new System.Windows.Forms.ComboBox();
            this.lblStop = new System.Windows.Forms.Label();
            this.cbBoxParity = new System.Windows.Forms.ComboBox();
            this.lblParity = new System.Windows.Forms.Label();
            this.btnCon = new System.Windows.Forms.Button();
            this.btnDes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnMensagen = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pnl1.SuspendLayout();
            this.pnMensagen.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnl1.Controls.Add(this.pnMensagen);
            this.pnl1.Controls.Add(this.btnExit);
            this.pnl1.Controls.Add(this.btnDes);
            this.pnl1.Controls.Add(this.btnCon);
            this.pnl1.Controls.Add(this.cbBoxParity);
            this.pnl1.Controls.Add(this.lblParity);
            this.pnl1.Controls.Add(this.cbBoxStop);
            this.pnl1.Controls.Add(this.lblStop);
            this.pnl1.Controls.Add(this.cbBoxData);
            this.pnl1.Controls.Add(this.lblData);
            this.pnl1.Controls.Add(this.cbBoxBaud);
            this.pnl1.Controls.Add(this.lblBaud);
            this.pnl1.Controls.Add(this.cbBoxPort);
            this.pnl1.Controls.Add(this.lblPort);
            this.pnl1.Location = new System.Drawing.Point(12, 12);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(186, 337);
            this.pnl1.TabIndex = 0;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(3, 18);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(71, 16);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "COM Port:";
            // 
            // cbBoxPort
            // 
            this.cbBoxPort.FormattingEnabled = true;
            this.cbBoxPort.Location = new System.Drawing.Point(83, 13);
            this.cbBoxPort.Name = "cbBoxPort";
            this.cbBoxPort.Size = new System.Drawing.Size(89, 21);
            this.cbBoxPort.TabIndex = 1;
            // 
            // cbBoxBaud
            // 
            this.cbBoxBaud.FormattingEnabled = true;
            this.cbBoxBaud.Location = new System.Drawing.Point(84, 50);
            this.cbBoxBaud.Name = "cbBoxBaud";
            this.cbBoxBaud.Size = new System.Drawing.Size(89, 21);
            this.cbBoxBaud.TabIndex = 2;
            // 
            // lblBaud
            // 
            this.lblBaud.AutoSize = true;
            this.lblBaud.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaud.Location = new System.Drawing.Point(3, 55);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(77, 16);
            this.lblBaud.TabIndex = 3;
            this.lblBaud.Text = "Baud Rate:";
            // 
            // cbBoxData
            // 
            this.cbBoxData.FormattingEnabled = true;
            this.cbBoxData.Location = new System.Drawing.Point(84, 91);
            this.cbBoxData.Name = "cbBoxData";
            this.cbBoxData.Size = new System.Drawing.Size(89, 21);
            this.cbBoxData.TabIndex = 4;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(3, 96);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(67, 16);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data Bits:";
            // 
            // cbBoxStop
            // 
            this.cbBoxStop.FormattingEnabled = true;
            this.cbBoxStop.Location = new System.Drawing.Point(84, 133);
            this.cbBoxStop.Name = "cbBoxStop";
            this.cbBoxStop.Size = new System.Drawing.Size(89, 21);
            this.cbBoxStop.TabIndex = 6;
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStop.Location = new System.Drawing.Point(3, 138);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(67, 16);
            this.lblStop.TabIndex = 7;
            this.lblStop.Text = "Stop Bits:";
            // 
            // cbBoxParity
            // 
            this.cbBoxParity.FormattingEnabled = true;
            this.cbBoxParity.Location = new System.Drawing.Point(84, 172);
            this.cbBoxParity.Name = "cbBoxParity";
            this.cbBoxParity.Size = new System.Drawing.Size(89, 21);
            this.cbBoxParity.TabIndex = 8;
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParity.Location = new System.Drawing.Point(3, 177);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(48, 16);
            this.lblParity.TabIndex = 9;
            this.lblParity.Text = "Parity:";
            // 
            // btnCon
            // 
            this.btnCon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCon.Location = new System.Drawing.Point(6, 205);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(75, 23);
            this.btnCon.TabIndex = 1;
            this.btnCon.Text = "Open Port";
            this.btnCon.UseVisualStyleBackColor = false;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // btnDes
            // 
            this.btnDes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDes.Enabled = false;
            this.btnDes.Location = new System.Drawing.Point(98, 205);
            this.btnDes.Name = "btnDes";
            this.btnDes.Size = new System.Drawing.Size(75, 23);
            this.btnDes.TabIndex = 10;
            this.btnDes.Text = "Close Port";
            this.btnDes.UseVisualStyleBackColor = false;
            this.btnDes.Click += new System.EventHandler(this.btnDes_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(6, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnMensagen
            // 
            this.pnMensagen.BackColor = System.Drawing.Color.Red;
            this.pnMensagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMensagen.Controls.Add(this.lblMsg);
            this.pnMensagen.Location = new System.Drawing.Point(7, 269);
            this.pnMensagen.Name = "pnMensagen";
            this.pnMensagen.Size = new System.Drawing.Size(167, 65);
            this.pnMensagen.TabIndex = 1;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(33, 18);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(96, 24);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "Open Port";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(225, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(301, 337);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(293, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor Serial";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(293, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Botoes/Leds";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(293, 311);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sensores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "IHM para Microcontrolador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnMensagen.ResumeLayout(false);
            this.pnMensagen.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.ComboBox cbBoxData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cbBoxBaud;
        private System.Windows.Forms.Label lblBaud;
        private System.Windows.Forms.ComboBox cbBoxPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ComboBox cbBoxParity;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.ComboBox cbBoxStop;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDes;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Panel pnMensagen;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

