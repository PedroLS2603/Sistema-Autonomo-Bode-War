namespace piBodeWar
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
            this.txtNarracao = new System.Windows.Forms.RichTextBox();
            this.btnNarração = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNarracao
            // 
            this.txtNarracao.Location = new System.Drawing.Point(12, 204);
            this.txtNarracao.Name = "txtNarracao";
            this.txtNarracao.Size = new System.Drawing.Size(318, 159);
            this.txtNarracao.TabIndex = 0;
            this.txtNarracao.Text = "";
            this.txtNarracao.TextChanged += new System.EventHandler(this.txtNarracao_TextChanged);
            // 
            // btnNarração
            // 
            this.btnNarração.Location = new System.Drawing.Point(12, 392);
            this.btnNarração.Name = "btnNarração";
            this.btnNarração.Size = new System.Drawing.Size(318, 23);
            this.btnNarração.TabIndex = 1;
            this.btnNarração.Text = "Narração";
            this.btnNarração.UseVisualStyleBackColor = true;
            this.btnNarração.Click += new System.EventHandler(this.btnNarração_Click);
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNarração);
            this.Controls.Add(this.txtNarracao);
            this.Name = "frmJogo";
            this.Text = "Jogo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtNarracao;
        private System.Windows.Forms.Button btnNarração;
    }
}