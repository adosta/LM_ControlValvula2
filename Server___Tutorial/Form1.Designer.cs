namespace Server___Tutorial
{
    partial class frmServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnListen = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUltGPM = new System.Windows.Forms.Label();
            this.lblGPM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(85, 13);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(100, 23);
            this.btnListen.TabIndex = 0;
            this.btnListen.Text = "Iniciar Server";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click_1);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(85, 120);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(321, 97);
            this.txtLog.TabIndex = 1;
            this.txtLog.Text = "";
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(85, 222);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(100, 20);
            this.txtSend.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(85, 248);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "button2";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 291);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(141, 333);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(807, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(540, 147);
            this.trackBar1.Maximum = 180;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(384, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(872, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(112, 42);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(175, 20);
            this.tbName.TabIndex = 9;
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(112, 68);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 20);
            this.tbIP.TabIndex = 10;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(86, 71);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(20, 13);
            this.lblIP.TabIndex = 11;
            this.lblIP.Text = "IP:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(2, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(104, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre del servidor:";
            // 
            // lblUltGPM
            // 
            this.lblUltGPM.AutoSize = true;
            this.lblUltGPM.Location = new System.Drawing.Point(12, 225);
            this.lblUltGPM.Name = "lblUltGPM";
            this.lblUltGPM.Size = new System.Drawing.Size(63, 13);
            this.lblUltGPM.TabIndex = 13;
            this.lblUltGPM.Text = "Ultimo GPM";
            // 
            // lblGPM
            // 
            this.lblGPM.AutoSize = true;
            this.lblGPM.Location = new System.Drawing.Point(31, 167);
            this.lblGPM.Name = "lblGPM";
            this.lblGPM.Size = new System.Drawing.Size(34, 13);
            this.lblGPM.TabIndex = 14;
            this.lblGPM.Text = "GPM:";
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 409);
            this.Controls.Add(this.lblGPM);
            this.Controls.Add(this.lblUltGPM);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnListen);
            this.Name = "frmServer";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnConectar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUltGPM;
        private System.Windows.Forms.Label lblGPM;
    }
}

