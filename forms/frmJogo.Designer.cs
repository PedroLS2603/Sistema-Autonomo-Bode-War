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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJogo));
            this.txtStatus = new System.Windows.Forms.RichTextBox();
            this.btnJogarCarta = new System.Windows.Forms.Button();
            this.btnNarracao = new System.Windows.Forms.Button();
            this.btnVerMao = new System.Windows.Forms.Button();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.btnVerificarVez = new System.Windows.Forms.Button();
            this.flpMao = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVerificarMesa = new System.Windows.Forms.Button();
            this.btnVerificarIlha = new System.Windows.Forms.Button();
            this.lblStatusRodada = new System.Windows.Forms.Label();
            this.lblIlha = new System.Windows.Forms.Label();
            this.lblBodes = new System.Windows.Forms.Label();
            this.flpMesa = new System.Windows.Forms.FlowLayoutPanel();
            this.tmrMinhaVez = new System.Windows.Forms.Timer(this.components);
            this.lblBodesRodada = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.lblJogador3 = new System.Windows.Forms.Label();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.lblJogador4 = new System.Windows.Forms.Label();
            this.lblRodada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(1028, 36);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(231, 144);
            this.txtStatus.TabIndex = 0;
            this.txtStatus.Text = "";
            // 
            // btnJogarCarta
            // 
            this.btnJogarCarta.Location = new System.Drawing.Point(29, 526);
            this.btnJogarCarta.Name = "btnJogarCarta";
            this.btnJogarCarta.Size = new System.Drawing.Size(161, 23);
            this.btnJogarCarta.TabIndex = 1;
            this.btnJogarCarta.Text = "Jogar carta";
            this.btnJogarCarta.UseVisualStyleBackColor = true;
            this.btnJogarCarta.Click += new System.EventHandler(this.btnJogarCarta_Click);
            // 
            // btnNarracao
            // 
            this.btnNarracao.Location = new System.Drawing.Point(1028, 198);
            this.btnNarracao.Name = "btnNarracao";
            this.btnNarracao.Size = new System.Drawing.Size(231, 23);
            this.btnNarracao.TabIndex = 2;
            this.btnNarracao.Text = "Narração";
            this.btnNarracao.UseVisualStyleBackColor = true;
            this.btnNarracao.Click += new System.EventHandler(this.btnNarracao_Click);
            // 
            // btnVerMao
            // 
            this.btnVerMao.Location = new System.Drawing.Point(29, 555);
            this.btnVerMao.Name = "btnVerMao";
            this.btnVerMao.Size = new System.Drawing.Size(161, 23);
            this.btnVerMao.TabIndex = 4;
            this.btnVerMao.Text = "Ver mão";
            this.btnVerMao.UseVisualStyleBackColor = true;
            this.btnVerMao.Click += new System.EventHandler(this.btnVerMao_Click);
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(29, 584);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(161, 23);
            this.btnIniciarPartida.TabIndex = 5;
            this.btnIniciarPartida.Text = "Iniciar partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // btnVerificarVez
            // 
            this.btnVerificarVez.Location = new System.Drawing.Point(29, 613);
            this.btnVerificarVez.Name = "btnVerificarVez";
            this.btnVerificarVez.Size = new System.Drawing.Size(161, 23);
            this.btnVerificarVez.TabIndex = 6;
            this.btnVerificarVez.Text = "Verificar vez";
            this.btnVerificarVez.UseVisualStyleBackColor = true;
            this.btnVerificarVez.Click += new System.EventHandler(this.btnVerificarVez_Click);
            // 
            // flpMao
            // 
            this.flpMao.BackColor = System.Drawing.Color.Transparent;
            this.flpMao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpMao.Location = new System.Drawing.Point(229, 525);
            this.flpMao.Name = "flpMao";
            this.flpMao.Size = new System.Drawing.Size(960, 184);
            this.flpMao.TabIndex = 7;
            // 
            // btnVerificarMesa
            // 
            this.btnVerificarMesa.Location = new System.Drawing.Point(29, 642);
            this.btnVerificarMesa.Name = "btnVerificarMesa";
            this.btnVerificarMesa.Size = new System.Drawing.Size(161, 23);
            this.btnVerificarMesa.TabIndex = 8;
            this.btnVerificarMesa.Text = "Verificar Mesa";
            this.btnVerificarMesa.UseVisualStyleBackColor = true;
            this.btnVerificarMesa.Click += new System.EventHandler(this.btnVerificarMesa_Click);
            // 
            // btnVerificarIlha
            // 
            this.btnVerificarIlha.Location = new System.Drawing.Point(29, 671);
            this.btnVerificarIlha.Name = "btnVerificarIlha";
            this.btnVerificarIlha.Size = new System.Drawing.Size(161, 23);
            this.btnVerificarIlha.TabIndex = 9;
            this.btnVerificarIlha.Text = "Verificar ilha";
            this.btnVerificarIlha.UseVisualStyleBackColor = true;
            this.btnVerificarIlha.Click += new System.EventHandler(this.btnVerificarIlha_Click);
            // 
            // lblStatusRodada
            // 
            this.lblStatusRodada.AutoSize = true;
            this.lblStatusRodada.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusRodada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblStatusRodada.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblStatusRodada.Location = new System.Drawing.Point(1028, 297);
            this.lblStatusRodada.Name = "lblStatusRodada";
            this.lblStatusRodada.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStatusRodada.Size = new System.Drawing.Size(165, 20);
            this.lblStatusRodada.TabIndex = 10;
            this.lblStatusRodada.Text = "Status - Não iniciado";
            // 
            // lblIlha
            // 
            this.lblIlha.AutoSize = true;
            this.lblIlha.BackColor = System.Drawing.Color.Transparent;
            this.lblIlha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblIlha.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblIlha.Location = new System.Drawing.Point(1030, 263);
            this.lblIlha.Name = "lblIlha";
            this.lblIlha.Size = new System.Drawing.Size(60, 20);
            this.lblIlha.TabIndex = 11;
            this.lblIlha.Text = "Ilha - 0";
            // 
            // lblBodes
            // 
            this.lblBodes.AutoSize = true;
            this.lblBodes.BackColor = System.Drawing.Color.Transparent;
            this.lblBodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblBodes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBodes.Location = new System.Drawing.Point(1029, 337);
            this.lblBodes.Name = "lblBodes";
            this.lblBodes.Size = new System.Drawing.Size(125, 20);
            this.lblBodes.TabIndex = 12;
            this.lblBodes.Text = "Meus bodes - 0";
            // 
            // flpMesa
            // 
            this.flpMesa.BackColor = System.Drawing.Color.Transparent;
            this.flpMesa.Location = new System.Drawing.Point(453, 355);
            this.flpMesa.Name = "flpMesa";
            this.flpMesa.Size = new System.Drawing.Size(514, 164);
            this.flpMesa.TabIndex = 13;
            // 
            // tmrMinhaVez
            // 
            this.tmrMinhaVez.Interval = 300;
            this.tmrMinhaVez.Tick += new System.EventHandler(this.tmrMinhaVez_Tick);
            // 
            // lblBodesRodada
            // 
            this.lblBodesRodada.AutoSize = true;
            this.lblBodesRodada.BackColor = System.Drawing.Color.Transparent;
            this.lblBodesRodada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblBodesRodada.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBodesRodada.Location = new System.Drawing.Point(1030, 372);
            this.lblBodesRodada.Name = "lblBodesRodada";
            this.lblBodesRodada.Size = new System.Drawing.Size(138, 20);
            this.lblBodesRodada.TabIndex = 14;
            this.lblBodesRodada.Text = "Bodes rodada - 0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(453, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 15);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(749, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 15);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(749, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 15);
            this.panel3.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(453, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(16, 15);
            this.panel4.TabIndex = 18;
            // 
            // lblJogador1
            // 
            this.lblJogador1.AutoSize = true;
            this.lblJogador1.BackColor = System.Drawing.Color.Transparent;
            this.lblJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblJogador1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblJogador1.Location = new System.Drawing.Point(484, 25);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(83, 20);
            this.lblJogador1.TabIndex = 19;
            this.lblJogador1.Text = "Jogador 1";
            // 
            // lblJogador3
            // 
            this.lblJogador3.AutoSize = true;
            this.lblJogador3.BackColor = System.Drawing.Color.Transparent;
            this.lblJogador3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblJogador3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblJogador3.Location = new System.Drawing.Point(484, 77);
            this.lblJogador3.Name = "lblJogador3";
            this.lblJogador3.Size = new System.Drawing.Size(83, 20);
            this.lblJogador3.TabIndex = 20;
            this.lblJogador3.Text = "Jogador 3";
            // 
            // lblJogador2
            // 
            this.lblJogador2.AutoSize = true;
            this.lblJogador2.BackColor = System.Drawing.Color.Transparent;
            this.lblJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblJogador2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblJogador2.Location = new System.Drawing.Point(785, 25);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(83, 20);
            this.lblJogador2.TabIndex = 21;
            this.lblJogador2.Text = "Jogador 2";
            // 
            // lblJogador4
            // 
            this.lblJogador4.AutoSize = true;
            this.lblJogador4.BackColor = System.Drawing.Color.Transparent;
            this.lblJogador4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblJogador4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblJogador4.Location = new System.Drawing.Point(785, 77);
            this.lblJogador4.Name = "lblJogador4";
            this.lblJogador4.Size = new System.Drawing.Size(83, 20);
            this.lblJogador4.TabIndex = 22;
            this.lblJogador4.Text = "Jogador 4";
            // 
            // lblRodada
            // 
            this.lblRodada.AutoSize = true;
            this.lblRodada.BackColor = System.Drawing.Color.Transparent;
            this.lblRodada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblRodada.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRodada.Location = new System.Drawing.Point(1030, 406);
            this.lblRodada.Name = "lblRodada";
            this.lblRodada.Size = new System.Drawing.Size(91, 20);
            this.lblRodada.TabIndex = 23;
            this.lblRodada.Text = "Rodada - 1";
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.lblRodada);
            this.Controls.Add(this.lblJogador4);
            this.Controls.Add(this.lblJogador2);
            this.Controls.Add(this.lblJogador3);
            this.Controls.Add(this.lblJogador1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBodesRodada);
            this.Controls.Add(this.flpMesa);
            this.Controls.Add(this.lblBodes);
            this.Controls.Add(this.lblIlha);
            this.Controls.Add(this.lblStatusRodada);
            this.Controls.Add(this.btnVerificarIlha);
            this.Controls.Add(this.btnVerificarMesa);
            this.Controls.Add(this.flpMao);
            this.Controls.Add(this.btnVerificarVez);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.btnVerMao);
            this.Controls.Add(this.btnNarracao);
            this.Controls.Add(this.btnJogarCarta);
            this.Controls.Add(this.txtStatus);
            this.Name = "frmJogo";
            this.Text = "frmJogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtStatus;
        private System.Windows.Forms.Button btnJogarCarta;
        private System.Windows.Forms.Button btnNarracao;
        private System.Windows.Forms.Button btnVerMao;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Button btnVerificarVez;
        private System.Windows.Forms.Button btnVerificarMesa;
        private System.Windows.Forms.Button btnVerificarIlha;
        private System.Windows.Forms.Label lblStatusRodada;
        private System.Windows.Forms.Label lblIlha;
        private System.Windows.Forms.FlowLayoutPanel flpMao;
        private System.Windows.Forms.Label lblBodes;
        private System.Windows.Forms.FlowLayoutPanel flpMesa;
        private System.Windows.Forms.Timer tmrMinhaVez;
        private System.Windows.Forms.Label lblBodesRodada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblJogador1;
        private System.Windows.Forms.Label lblJogador3;
        private System.Windows.Forms.Label lblJogador2;
        private System.Windows.Forms.Label lblJogador4;
        private System.Windows.Forms.Label lblRodada;
    }
}