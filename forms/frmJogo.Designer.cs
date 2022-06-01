namespace piBodeWar.forms
{
    partial class frmJogo
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
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.flpMao = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStatusRodada = new System.Windows.Forms.Label();
            this.lblBodes = new System.Windows.Forms.Label();
            this.flpMesa = new System.Windows.Forms.FlowLayoutPanel();
            this.tmrMinhaVez = new System.Windows.Forms.Timer(this.components);
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.lblJogador3 = new System.Windows.Forms.Label();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.lblJogador4 = new System.Windows.Forms.Label();
            this.lblRodada = new System.Windows.Forms.Label();
            this.pnlIlha = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(1098, 54);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(123, 28);
            this.btnIniciarPartida.TabIndex = 5;
            this.btnIniciarPartida.Text = "Iniciar partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // flpMao
            // 
            this.flpMao.BackColor = System.Drawing.Color.Transparent;
            this.flpMao.Location = new System.Drawing.Point(440, 525);
            this.flpMao.Name = "flpMao";
            this.flpMao.Size = new System.Drawing.Size(919, 210);
            this.flpMao.TabIndex = 7;
            // 
            // lblStatusRodada
            // 
            this.lblStatusRodada.AutoSize = true;
            this.lblStatusRodada.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusRodada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblStatusRodada.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblStatusRodada.Location = new System.Drawing.Point(6, 34);
            this.lblStatusRodada.Name = "lblStatusRodada";
            this.lblStatusRodada.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStatusRodada.Size = new System.Drawing.Size(165, 20);
            this.lblStatusRodada.TabIndex = 10;
            this.lblStatusRodada.Text = "Status - Não iniciado";
            // 
            // lblBodes
            // 
            this.lblBodes.AutoSize = true;
            this.lblBodes.BackColor = System.Drawing.Color.Transparent;
            this.lblBodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblBodes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBodes.Location = new System.Drawing.Point(1153, 655);
            this.lblBodes.Name = "lblBodes";
            this.lblBodes.Size = new System.Drawing.Size(125, 20);
            this.lblBodes.TabIndex = 12;
            this.lblBodes.Text = "Meus bodes - 0";
            // 
            // flpMesa
            // 
            this.flpMesa.BackColor = System.Drawing.Color.Transparent;
            this.flpMesa.Location = new System.Drawing.Point(833, 266);
            this.flpMesa.Name = "flpMesa";
            this.flpMesa.Size = new System.Drawing.Size(514, 222);
            this.flpMesa.TabIndex = 13;
            // 
            // tmrMinhaVez
            // 
            this.tmrMinhaVez.Interval = 666;
            this.tmrMinhaVez.Tick += new System.EventHandler(this.tmrMinhaVez_Tick);
            // 
            // lblJogador1
            // 
            this.lblJogador1.AutoSize = true;
            this.lblJogador1.BackColor = System.Drawing.Color.Transparent;
            this.lblJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblJogador1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblJogador1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblJogador1.Location = new System.Drawing.Point(994, 175);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(29, 20);
            this.lblJogador1.TabIndex = 19;
            this.lblJogador1.Text = "P1";
            this.lblJogador1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblJogador3
            // 
            this.lblJogador3.AutoSize = true;
            this.lblJogador3.BackColor = System.Drawing.Color.Transparent;
            this.lblJogador3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblJogador3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblJogador3.Location = new System.Drawing.Point(1153, 175);
            this.lblJogador3.Name = "lblJogador3";
            this.lblJogador3.Size = new System.Drawing.Size(29, 20);
            this.lblJogador3.TabIndex = 20;
            this.lblJogador3.Text = "P3";
            this.lblJogador3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblJogador2
            // 
            this.lblJogador2.AutoSize = true;
            this.lblJogador2.BackColor = System.Drawing.Color.Transparent;
            this.lblJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblJogador2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblJogador2.Location = new System.Drawing.Point(1073, 175);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(29, 20);
            this.lblJogador2.TabIndex = 21;
            this.lblJogador2.Text = "P2";
            this.lblJogador2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblJogador4
            // 
            this.lblJogador4.AutoSize = true;
            this.lblJogador4.BackColor = System.Drawing.Color.Transparent;
            this.lblJogador4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblJogador4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblJogador4.Location = new System.Drawing.Point(1238, 174);
            this.lblJogador4.Name = "lblJogador4";
            this.lblJogador4.Size = new System.Drawing.Size(29, 20);
            this.lblJogador4.TabIndex = 22;
            this.lblJogador4.Text = "P4";
            this.lblJogador4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRodada
            // 
            this.lblRodada.AutoSize = true;
            this.lblRodada.BackColor = System.Drawing.Color.Transparent;
            this.lblRodada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblRodada.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRodada.Location = new System.Drawing.Point(6, 74);
            this.lblRodada.Name = "lblRodada";
            this.lblRodada.Size = new System.Drawing.Size(91, 20);
            this.lblRodada.TabIndex = 23;
            this.lblRodada.Text = "Rodada - 1";
            // 
            // pnlIlha
            // 
            this.pnlIlha.BackColor = System.Drawing.Color.Transparent;
            this.pnlIlha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlIlha.Location = new System.Drawing.Point(0, 0);
            this.pnlIlha.Name = "pnlIlha";
            this.pnlIlha.Size = new System.Drawing.Size(482, 284);
            this.pnlIlha.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblStatusRodada);
            this.groupBox1.Controls.Add(this.lblRodada);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(647, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 97);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.BackColor = System.Drawing.Color.Transparent;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.txtStatus.Location = new System.Drawing.Point(6, 16);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(18, 20);
            this.txtStatus.TabIndex = 26;
            this.txtStatus.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(64, 525);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 210);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Narração";
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::piBodeWar.Properties.Resources.table_BOW;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBodes);
            this.Controls.Add(this.pnlIlha);
            this.Controls.Add(this.lblJogador4);
            this.Controls.Add(this.lblJogador2);
            this.Controls.Add(this.lblJogador3);
            this.Controls.Add(this.lblJogador1);
            this.Controls.Add(this.flpMesa);
            this.Controls.Add(this.flpMao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmJogo";
            this.Text = "frmJogo";
            this.Load += new System.EventHandler(this.frmJogo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label lblStatusRodada;
        private System.Windows.Forms.FlowLayoutPanel flpMao;
        private System.Windows.Forms.Label lblBodes;
        private System.Windows.Forms.FlowLayoutPanel flpMesa;
        private System.Windows.Forms.Timer tmrMinhaVez;
        private System.Windows.Forms.Label lblJogador1;
        private System.Windows.Forms.Label lblJogador3;
        private System.Windows.Forms.Label lblJogador2;
        private System.Windows.Forms.Label lblJogador4;
        private System.Windows.Forms.Label lblRodada;
        private System.Windows.Forms.Panel pnlIlha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}