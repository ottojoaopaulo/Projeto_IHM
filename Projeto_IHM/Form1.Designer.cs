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
            this.pnMensagen = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDes = new System.Windows.Forms.Button();
            this.btnCon = new System.Windows.Forms.Button();
            this.cbBoxParity = new System.Windows.Forms.ComboBox();
            this.lblParity = new System.Windows.Forms.Label();
            this.cbBoxStop = new System.Windows.Forms.ComboBox();
            this.lblStop = new System.Windows.Forms.Label();
            this.cbBoxData = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.cbBoxBaud = new System.Windows.Forms.ComboBox();
            this.lblBaud = new System.Windows.Forms.Label();
            this.cbBoxPort = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRec = new System.Windows.Forms.TextBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.tx = new System.Windows.Forms.GroupBox();
            this.chBoxEnviar = new System.Windows.Forms.CheckBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBotao2 = new System.Windows.Forms.Button();
            this.pnLed2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBotao1 = new System.Windows.Forms.Button();
            this.pnLed1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblS1 = new System.Windows.Forms.Label();
            this.lblS2 = new System.Windows.Forms.Label();
            this.lblSensor1 = new System.Windows.Forms.Label();
            this.lblSensor2 = new System.Windows.Forms.Label();
            this.pnl1.SuspendLayout();
            this.pnMensagen.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tx.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnLed2.SuspendLayout();
            this.pnLed1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // cbBoxPort
            // 
            this.cbBoxPort.FormattingEnabled = true;
            this.cbBoxPort.Location = new System.Drawing.Point(83, 13);
            this.cbBoxPort.Name = "cbBoxPort";
            this.cbBoxPort.Size = new System.Drawing.Size(89, 21);
            this.cbBoxPort.TabIndex = 1;
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
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.tx);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(293, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor Serial";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.txtRec);
            this.groupBox1.Controls.Add(this.btnApagar);
            this.groupBox1.Location = new System.Drawing.Point(6, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recepcao";
            // 
            // txtRec
            // 
            this.txtRec.Location = new System.Drawing.Point(6, 48);
            this.txtRec.Multiline = true;
            this.txtRec.Name = "txtRec";
            this.txtRec.Size = new System.Drawing.Size(269, 158);
            this.txtRec.TabIndex = 1;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(200, 19);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 0;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // tx
            // 
            this.tx.BackColor = System.Drawing.Color.Silver;
            this.tx.Controls.Add(this.chBoxEnviar);
            this.tx.Controls.Add(this.btnEnviar);
            this.tx.Controls.Add(this.txtEnviar);
            this.tx.Location = new System.Drawing.Point(6, 6);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(281, 73);
            this.tx.TabIndex = 0;
            this.tx.TabStop = false;
            this.tx.Text = "Transmissao";
            // 
            // chBoxEnviar
            // 
            this.chBoxEnviar.AutoSize = true;
            this.chBoxEnviar.Location = new System.Drawing.Point(6, 45);
            this.chBoxEnviar.Name = "chBoxEnviar";
            this.chBoxEnviar.Size = new System.Drawing.Size(41, 17);
            this.chBoxEnviar.TabIndex = 2;
            this.chBoxEnviar.Text = "CR";
            this.chBoxEnviar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(200, 19);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 20);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(6, 19);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(188, 20);
            this.txtEnviar.TabIndex = 0;
            this.txtEnviar.Click += new System.EventHandler(this.txtEnviar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBotao2);
            this.tabPage2.Controls.Add(this.pnLed2);
            this.tabPage2.Controls.Add(this.btnBotao1);
            this.tabPage2.Controls.Add(this.pnLed1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(293, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Botoes/Leds";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBotao2
            // 
            this.btnBotao2.Location = new System.Drawing.Point(126, 15);
            this.btnBotao2.Name = "btnBotao2";
            this.btnBotao2.Size = new System.Drawing.Size(75, 23);
            this.btnBotao2.TabIndex = 3;
            this.btnBotao2.Text = "Botao 2";
            this.btnBotao2.UseVisualStyleBackColor = true;
            this.btnBotao2.Click += new System.EventHandler(this.btnBotao2_Click);
            // 
            // pnLed2
            // 
            this.pnLed2.BackColor = System.Drawing.Color.Maroon;
            this.pnLed2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnLed2.Controls.Add(this.label2);
            this.pnLed2.Location = new System.Drawing.Point(126, 56);
            this.pnLed2.Name = "pnLed2";
            this.pnLed2.Size = new System.Drawing.Size(75, 52);
            this.pnLed2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Led 2";
            // 
            // btnBotao1
            // 
            this.btnBotao1.Location = new System.Drawing.Point(21, 15);
            this.btnBotao1.Name = "btnBotao1";
            this.btnBotao1.Size = new System.Drawing.Size(75, 23);
            this.btnBotao1.TabIndex = 1;
            this.btnBotao1.Text = "Botao 1";
            this.btnBotao1.UseVisualStyleBackColor = true;
            this.btnBotao1.Click += new System.EventHandler(this.btnBotao1_Click);
            // 
            // pnLed1
            // 
            this.pnLed1.BackColor = System.Drawing.Color.Maroon;
            this.pnLed1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnLed1.Controls.Add(this.label1);
            this.pnLed1.Enabled = false;
            this.pnLed1.Location = new System.Drawing.Point(21, 56);
            this.pnLed1.Name = "pnLed1";
            this.pnLed1.Size = new System.Drawing.Size(75, 52);
            this.pnLed1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Led 1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(293, 311);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sensores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.lblSensor2);
            this.groupBox2.Controls.Add(this.lblSensor1);
            this.groupBox2.Controls.Add(this.lblS2);
            this.groupBox2.Controls.Add(this.lblS1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 154);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // lblS1
            // 
            this.lblS1.AutoSize = true;
            this.lblS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS1.Location = new System.Drawing.Point(21, 31);
            this.lblS1.Name = "lblS1";
            this.lblS1.Size = new System.Drawing.Size(106, 27);
            this.lblS1.TabIndex = 0;
            this.lblS1.Text = "Sensor 1:";
            this.lblS1.Click += new System.EventHandler(this.lblS1_Click);
            // 
            // lblS2
            // 
            this.lblS2.AutoSize = true;
            this.lblS2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS2.Location = new System.Drawing.Point(21, 93);
            this.lblS2.Name = "lblS2";
            this.lblS2.Size = new System.Drawing.Size(106, 27);
            this.lblS2.TabIndex = 1;
            this.lblS2.Text = "Sensor 2:";
            // 
            // lblSensor1
            // 
            this.lblSensor1.AutoSize = true;
            this.lblSensor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensor1.Location = new System.Drawing.Point(157, 31);
            this.lblSensor1.Name = "lblSensor1";
            this.lblSensor1.Size = new System.Drawing.Size(69, 29);
            this.lblSensor1.TabIndex = 2;
            this.lblSensor1.Text = "0000";
            this.lblSensor1.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblSensor2
            // 
            this.lblSensor2.AutoSize = true;
            this.lblSensor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensor2.Location = new System.Drawing.Point(157, 93);
            this.lblSensor2.Name = "lblSensor2";
            this.lblSensor2.Size = new System.Drawing.Size(69, 29);
            this.lblSensor2.TabIndex = 3;
            this.lblSensor2.Text = "0000";
            this.lblSensor2.Click += new System.EventHandler(this.label4_Click);
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
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tx.ResumeLayout(false);
            this.tx.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnLed2.ResumeLayout(false);
            this.pnLed2.PerformLayout();
            this.pnLed1.ResumeLayout(false);
            this.pnLed1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox tx;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.CheckBox chBoxEnviar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRec;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnBotao2;
        private System.Windows.Forms.Panel pnLed2;
        private System.Windows.Forms.Button btnBotao1;
        private System.Windows.Forms.Panel pnLed1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblS1;
        private System.Windows.Forms.Label lblSensor2;
        private System.Windows.Forms.Label lblSensor1;
        private System.Windows.Forms.Label lblS2;
    }
}

