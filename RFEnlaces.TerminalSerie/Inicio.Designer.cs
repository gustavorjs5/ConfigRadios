namespace RFEnlaces.TerminalSerie
{
    partial class Inicio
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RateSerial = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RFRate = new System.Windows.Forms.ComboBox();
            this.comboBoxMHZ = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeconectado = new System.Windows.Forms.Label();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblFecha.Location = new System.Drawing.Point(350, 12);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(233, 20);
            this.lblFecha.TabIndex = 29;
            this.lblFecha.Text = "Miercoles, 10  noviembre  2017";
            // 
            // lblhora
            // 
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblhora.Location = new System.Drawing.Point(450, 32);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(200, 88);
            this.lblhora.TabIndex = 28;
            this.lblhora.Text = "10:59:58";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(10, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 21);
            this.label15.TabIndex = 37;
            this.label15.Text = "Sumario del sistema:";
            // 
            // port
            // 
            this.port.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.port.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port.FormattingEnabled = true;
            this.port.Location = new System.Drawing.Point(60, 38);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(142, 33);
            this.port.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(282, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 37);
            this.button1.TabIndex = 39;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnDesconectar);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 100);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puerto COM";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDesconectar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDesconectar.Location = new System.Drawing.Point(461, 35);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(125, 36);
            this.btnDesconectar.TabIndex = 40;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 195);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.RateSerial);
            this.groupBox5.Location = new System.Drawing.Point(396, 35);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(345, 147);
            this.groupBox5.TabIndex = 46;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parametros Series";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Serial Rate (bps)";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // RateSerial
            // 
            this.RateSerial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RateSerial.FormattingEnabled = true;
            this.RateSerial.Location = new System.Drawing.Point(181, 37);
            this.RateSerial.Name = "RateSerial";
            this.RateSerial.Size = new System.Drawing.Size(120, 28);
            this.RateSerial.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.RFRate);
            this.groupBox4.Controls.Add(this.comboBoxMHZ);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(14, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(348, 157);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parametros RF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frecuencia (Mhz)";
            // 
            // RFRate
            // 
            this.RFRate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RFRate.FormattingEnabled = true;
            this.RFRate.Location = new System.Drawing.Point(158, 79);
            this.RFRate.Name = "RFRate";
            this.RFRate.Size = new System.Drawing.Size(120, 28);
            this.RFRate.TabIndex = 7;
            // 
            // comboBoxMHZ
            // 
            this.comboBoxMHZ.DropDownHeight = 90;
            this.comboBoxMHZ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxMHZ.FormattingEnabled = true;
            this.comboBoxMHZ.IntegralHeight = false;
            this.comboBoxMHZ.ItemHeight = 20;
            this.comboBoxMHZ.Location = new System.Drawing.Point(160, 33);
            this.comboBoxMHZ.Name = "comboBoxMHZ";
            this.comboBoxMHZ.Size = new System.Drawing.Size(118, 28);
            this.comboBoxMHZ.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "RF Tx Rate";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnDeconectado);
            this.groupBox3.Controls.Add(this.btnEscribir);
            this.groupBox3.Controls.Add(this.btnLeer);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(772, 67);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            // 
            // btnDeconectado
            // 
            this.btnDeconectado.AutoSize = true;
            this.btnDeconectado.BackColor = System.Drawing.Color.Red;
            this.btnDeconectado.Location = new System.Drawing.Point(60, 26);
            this.btnDeconectado.Name = "btnDeconectado";
            this.btnDeconectado.Size = new System.Drawing.Size(125, 20);
            this.btnDeconectado.TabIndex = 41;
            this.btnDeconectado.Text = "Desconectado";
            // 
            // btnEscribir
            // 
            this.btnEscribir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEscribir.Location = new System.Drawing.Point(461, 18);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(125, 36);
            this.btnEscribir.TabIndex = 40;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeer.Location = new System.Drawing.Point(282, 17);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(126, 37);
            this.btnLeer.TabIndex = 39;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.Button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblhora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 547);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 63);
            this.panel1.TabIndex = 42;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(772, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "InicioResumen";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox port;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox RateSerial;
        private System.Windows.Forms.ComboBox RFRate;
        private System.Windows.Forms.ComboBox comboBoxMHZ;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label btnDeconectado;
    }
}