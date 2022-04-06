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
            this.txtStatus = new System.Windows.Forms.RichTextBox();
            this.btnJogarCarta = new System.Windows.Forms.Button();
            this.btnNarracao = new System.Windows.Forms.Button();
            this.btnVerMao = new System.Windows.Forms.Button();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.btnVerificarVez = new System.Windows.Forms.Button();
            this.flpMao = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVerificarMesa = new System.Windows.Forms.Button();
            this.btnVerificarIlha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(765, 38);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(231, 144);
            this.txtStatus.TabIndex = 0;
            this.txtStatus.Text = "";
            this.txtStatus.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnJogarCarta
            // 
            this.btnJogarCarta.Location = new System.Drawing.Point(40, 437);
            this.btnJogarCarta.Name = "btnJogarCarta";
            this.btnJogarCarta.Size = new System.Drawing.Size(161, 23);
            this.btnJogarCarta.TabIndex = 1;
            this.btnJogarCarta.Text = "Jogar carta";
            this.btnJogarCarta.UseVisualStyleBackColor = true;
            this.btnJogarCarta.Click += new System.EventHandler(this.btnJogarCarta_Click);
            // 
            // btnNarracao
            // 
            this.btnNarracao.Location = new System.Drawing.Point(765, 215);
            this.btnNarracao.Name = "btnNarracao";
            this.btnNarracao.Size = new System.Drawing.Size(231, 23);
            this.btnNarracao.TabIndex = 2;
            this.btnNarracao.Text = "Narração";
            this.btnNarracao.UseVisualStyleBackColor = true;
            this.btnNarracao.Click += new System.EventHandler(this.btnNarracao_Click);
            // 
            // btnVerMao
            // 
            this.btnVerMao.Location = new System.Drawing.Point(40, 466);
            this.btnVerMao.Name = "btnVerMao";
            this.btnVerMao.Size = new System.Drawing.Size(161, 23);
            this.btnVerMao.TabIndex = 4;
            this.btnVerMao.Text = "Ver mão";
            this.btnVerMao.UseVisualStyleBackColor = true;
            this.btnVerMao.Click += new System.EventHandler(this.btnVerMao_Click);
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(40, 495);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(161, 23);
            this.btnIniciarPartida.TabIndex = 5;
            this.btnIniciarPartida.Text = "Iniciar partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // btnVerificarVez
            // 
            this.btnVerificarVez.Location = new System.Drawing.Point(40, 524);
            this.btnVerificarVez.Name = "btnVerificarVez";
            this.btnVerificarVez.Size = new System.Drawing.Size(161, 23);
            this.btnVerificarVez.TabIndex = 6;
            this.btnVerificarVez.Text = "Verificar vez";
            this.btnVerificarVez.UseVisualStyleBackColor = true;
            this.btnVerificarVez.Click += new System.EventHandler(this.btnVerificarVez_Click);
            // 
            // flpMao
            // 
            this.flpMao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpMao.Location = new System.Drawing.Point(240, 436);
            this.flpMao.Name = "flpMao";
            this.flpMao.Size = new System.Drawing.Size(1012, 184);
            this.flpMao.TabIndex = 7;
            // 
            // btnVerificarMesa
            // 
            this.btnVerificarMesa.Location = new System.Drawing.Point(40, 553);
            this.btnVerificarMesa.Name = "btnVerificarMesa";
            this.btnVerificarMesa.Size = new System.Drawing.Size(161, 23);
            this.btnVerificarMesa.TabIndex = 8;
            this.btnVerificarMesa.Text = "Verificar Mesa";
            this.btnVerificarMesa.UseVisualStyleBackColor = true;
            this.btnVerificarMesa.Click += new System.EventHandler(this.btnVerificarMesa_Click);
            // 
            // btnVerificarIlha
            // 
            this.btnVerificarIlha.Location = new System.Drawing.Point(40, 582);
            this.btnVerificarIlha.Name = "btnVerificarIlha";
            this.btnVerificarIlha.Size = new System.Drawing.Size(161, 23);
            this.btnVerificarIlha.TabIndex = 9;
            this.btnVerificarIlha.Text = "Verificar ilha";
            this.btnVerificarIlha.UseVisualStyleBackColor = true;
            this.btnVerificarIlha.Click += new System.EventHandler(this.btnVerificarIlha_Click);
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtStatus;
        private System.Windows.Forms.Button btnJogarCarta;
        private System.Windows.Forms.Button btnNarracao;
        private System.Windows.Forms.Button btnVerMao;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Button btnVerificarVez;
        private System.Windows.Forms.FlowLayoutPanel flpMao;
        private System.Windows.Forms.Button btnVerificarMesa;
        private System.Windows.Forms.Button btnVerificarIlha;
    }
}