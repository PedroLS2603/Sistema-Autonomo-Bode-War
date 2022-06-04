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
            this.txtStatus = new System.Windows.Forms.Label();
            this.pbxIlha = new System.Windows.Forms.PictureBox();
            this.pnlNarracao = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblIlha = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIlha)).BeginInit();
            this.pnlNarracao.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarPartida.BackgroundImage = global::piBodeWar.Properties.Resources.iniciar1;
            this.btnIniciarPartida.FlatAppearance.BorderSize = 0;
            this.btnIniciarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarPartida.Location = new System.Drawing.Point(1236, -2);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(119, 48);
            this.btnIniciarPartida.TabIndex = 5;
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            this.btnIniciarPartida.MouseEnter += new System.EventHandler(this.btnIniciarPartida_MouseEnter);
            this.btnIniciarPartida.MouseLeave += new System.EventHandler(this.btnIniciarPartida_MouseLeave);
            // 
            // flpMao
            // 
            this.flpMao.BackColor = System.Drawing.Color.Transparent;
            this.flpMao.Location = new System.Drawing.Point(510, 557);
            this.flpMao.Name = "flpMao";
            this.flpMao.Size = new System.Drawing.Size(854, 190);
            this.flpMao.TabIndex = 7;
            // 
            // lblStatusRodada
            // 
            this.lblStatusRodada.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusRodada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusRodada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblStatusRodada.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblStatusRodada.Location = new System.Drawing.Point(0, 0);
            this.lblStatusRodada.Name = "lblStatusRodada";
            this.lblStatusRodada.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStatusRodada.Size = new System.Drawing.Size(297, 55);
            this.lblStatusRodada.TabIndex = 10;
            this.lblStatusRodada.Text = "Não iniciado";
            this.lblStatusRodada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBodes
            // 
            this.lblBodes.BackColor = System.Drawing.Color.Transparent;
            this.lblBodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblBodes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBodes.Location = new System.Drawing.Point(0, 0);
            this.lblBodes.Name = "lblBodes";
            this.lblBodes.Size = new System.Drawing.Size(82, 42);
            this.lblBodes.TabIndex = 12;
            this.lblBodes.Text = "0";
            this.lblBodes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpMesa
            // 
            this.flpMesa.BackColor = System.Drawing.Color.Transparent;
            this.flpMesa.Location = new System.Drawing.Point(833, 246);
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
            this.lblJogador1.BackColor = System.Drawing.Color.Transparent;
            this.lblJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblJogador1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblJogador1.Location = new System.Drawing.Point(27, 0);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(29, 20);
            this.lblJogador1.TabIndex = 19;
            this.lblJogador1.Text = "P1";
            this.lblJogador1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblJogador1.Click += new System.EventHandler(this.lblJogador1_Click);
            // 
            // lblJogador3
            // 
            this.lblJogador3.AutoSize = true;
            this.lblJogador3.BackColor = System.Drawing.Color.Transparent;
            this.lblJogador3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblJogador3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblJogador3.Location = new System.Drawing.Point(1219, 148);
            this.lblJogador3.Name = "lblJogador3";
            this.lblJogador3.Size = new System.Drawing.Size(29, 20);
            this.lblJogador3.TabIndex = 20;
            this.lblJogador3.Text = "P3";
            this.lblJogador3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblJogador2
            // 
            this.lblJogador2.BackColor = System.Drawing.Color.Transparent;
            this.lblJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblJogador2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblJogador2.Location = new System.Drawing.Point(18, 17);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(65, 20);
            this.lblJogador2.TabIndex = 21;
            this.lblJogador2.Text = "Player2";
            this.lblJogador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblJogador2.Click += new System.EventHandler(this.lblJogador2_Click);
            // 
            // lblJogador4
            // 
            this.lblJogador4.AutoSize = true;
            this.lblJogador4.BackColor = System.Drawing.Color.Transparent;
            this.lblJogador4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblJogador4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblJogador4.Location = new System.Drawing.Point(1291, 137);
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
            this.lblRodada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblRodada.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRodada.Location = new System.Drawing.Point(668, 40);
            this.lblRodada.Name = "lblRodada";
            this.lblRodada.Size = new System.Drawing.Size(30, 31);
            this.lblRodada.TabIndex = 23;
            this.lblRodada.Text = "1";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.BackColor = System.Drawing.Color.Transparent;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.txtStatus.Location = new System.Drawing.Point(3, 0);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(18, 20);
            this.txtStatus.TabIndex = 26;
            this.txtStatus.Text = "0";
            // 
            // pbxIlha
            // 
            this.pbxIlha.BackColor = System.Drawing.Color.Transparent;
            this.pbxIlha.Location = new System.Drawing.Point(215, 72);
            this.pbxIlha.Name = "pbxIlha";
            this.pbxIlha.Size = new System.Drawing.Size(233, 210);
            this.pbxIlha.TabIndex = 28;
            this.pbxIlha.TabStop = false;
            // 
            // pnlNarracao
            // 
            this.pnlNarracao.BackColor = System.Drawing.Color.Transparent;
            this.pnlNarracao.Controls.Add(this.txtStatus);
            this.pnlNarracao.Location = new System.Drawing.Point(44, 512);
            this.pnlNarracao.Name = "pnlNarracao";
            this.pnlNarracao.Size = new System.Drawing.Size(341, 235);
            this.pnlNarracao.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblStatusRodada);
            this.panel1.Location = new System.Drawing.Point(833, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 55);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblBodes);
            this.panel2.Location = new System.Drawing.Point(897, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(82, 42);
            this.panel2.TabIndex = 31;
            // 
            // lblIlha
            // 
            this.lblIlha.BackColor = System.Drawing.Color.Transparent;
            this.lblIlha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIlha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIlha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblIlha.Location = new System.Drawing.Point(0, 0);
            this.lblIlha.Name = "lblIlha";
            this.lblIlha.Size = new System.Drawing.Size(58, 31);
            this.lblIlha.TabIndex = 32;
            this.lblIlha.Text = "0";
            this.lblIlha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lblIlha);
            this.panel3.Location = new System.Drawing.Point(98, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(58, 31);
            this.panel3.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.lblJogador1);
            this.panel4.Location = new System.Drawing.Point(974, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(80, 60);
            this.panel4.TabIndex = 34;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.lblJogador2);
            this.panel5.Location = new System.Drawing.Point(1069, 86);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(86, 58);
            this.panel5.TabIndex = 35;
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::piBodeWar.Properties.Resources.table_BOW;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNarracao);
            this.Controls.Add(this.pbxIlha);
            this.Controls.Add(this.lblRodada);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lblJogador4);
            this.Controls.Add(this.lblJogador3);
            this.Controls.Add(this.flpMesa);
            this.Controls.Add(this.flpMao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmJogo";
            this.Text = "frmJogo";
            this.Load += new System.EventHandler(this.frmJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIlha)).EndInit();
            this.pnlNarracao.ResumeLayout(false);
            this.pnlNarracao.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
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
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.PictureBox pbxIlha;
        private System.Windows.Forms.Panel pnlNarracao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblIlha;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}