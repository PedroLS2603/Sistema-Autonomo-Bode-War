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
            this.txtStatusRodada = new System.Windows.Forms.Label();
            this.lblIlha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flpMesa = new System.Windows.Forms.FlowLayoutPanel();
            this.tmrStatusPartida = new System.Windows.Forms.Timer(this.components);
            this.tmrAtualizaMao = new System.Windows.Forms.Timer(this.components);
            this.tmrMinhaVez = new System.Windows.Forms.Timer(this.components);
            this.tmrAtualizaMesa = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(1028, 36);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(231, 144);
            this.txtStatus.TabIndex = 0;
            this.txtStatus.Text = "";
            this.txtStatus.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
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
            // txtStatusRodada
            // 
            this.txtStatusRodada.AutoSize = true;
            this.txtStatusRodada.BackColor = System.Drawing.Color.Transparent;
            this.txtStatusRodada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.txtStatusRodada.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtStatusRodada.Location = new System.Drawing.Point(1028, 297);
            this.txtStatusRodada.Name = "txtStatusRodada";
            this.txtStatusRodada.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStatusRodada.Size = new System.Drawing.Size(165, 20);
            this.txtStatusRodada.TabIndex = 10;
            this.txtStatusRodada.Text = "Status - Não iniciado";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1029, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Meus bodes - 0";
            // 
            // flpMesa
            // 
            this.flpMesa.BackColor = System.Drawing.Color.Transparent;
            this.flpMesa.Location = new System.Drawing.Point(453, 355);
            this.flpMesa.Name = "flpMesa";
            this.flpMesa.Size = new System.Drawing.Size(514, 164);
            this.flpMesa.TabIndex = 13;
            // 
            // tmrStatusPartida
            // 
            this.tmrStatusPartida.Interval = 500;
            this.tmrStatusPartida.Tick += new System.EventHandler(this.tmrStatusPartida_Tick);
            // 
            // tmrAtualizaMao
            // 
            this.tmrAtualizaMao.Interval = 1600;
            this.tmrAtualizaMao.Tick += new System.EventHandler(this.tmrAtualizaTela_Tick);
            // 
            // tmrMinhaVez
            // 
            this.tmrMinhaVez.Interval = 1500;
            this.tmrMinhaVez.Tick += new System.EventHandler(this.tmrMinhaVez_Tick);
            // 
            // tmrAtualizaMesa
            // 
            this.tmrAtualizaMesa.Interval = 500;
            this.tmrAtualizaMesa.Tick += new System.EventHandler(this.tmrAtualizaMesa_Tick);
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.flpMesa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIlha);
            this.Controls.Add(this.txtStatusRodada);
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
            this.Load += new System.EventHandler(this.frmJogo_Load);
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
        private System.Windows.Forms.Label txtStatusRodada;
        private System.Windows.Forms.Label lblIlha;
        private System.Windows.Forms.FlowLayoutPanel flpMao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpMesa;
        private System.Windows.Forms.Timer tmrStatusPartida;
        private System.Windows.Forms.Timer tmrAtualizaMao;
        private System.Windows.Forms.Timer tmrMinhaVez;
        private System.Windows.Forms.Timer tmrAtualizaMesa;
    }
}