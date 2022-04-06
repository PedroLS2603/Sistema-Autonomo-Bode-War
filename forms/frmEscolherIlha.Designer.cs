namespace piBodeWar.forms
{
    partial class frmEscolherIlha
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
            this.btnIlhaOpcao1 = new System.Windows.Forms.Button();
            this.btnIlhaOpcao2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIlhaOpcao1
            // 
            this.btnIlhaOpcao1.Location = new System.Drawing.Point(44, 91);
            this.btnIlhaOpcao1.Name = "btnIlhaOpcao1";
            this.btnIlhaOpcao1.Size = new System.Drawing.Size(56, 31);
            this.btnIlhaOpcao1.TabIndex = 0;
            this.btnIlhaOpcao1.UseVisualStyleBackColor = true;
            this.btnIlhaOpcao1.Click += new System.EventHandler(this.btnIlhaOpcao1_Click);
            // 
            // btnIlhaOpcao2
            // 
            this.btnIlhaOpcao2.Location = new System.Drawing.Point(187, 91);
            this.btnIlhaOpcao2.Name = "btnIlhaOpcao2";
            this.btnIlhaOpcao2.Size = new System.Drawing.Size(56, 31);
            this.btnIlhaOpcao2.TabIndex = 1;
            this.btnIlhaOpcao2.UseVisualStyleBackColor = true;
            this.btnIlhaOpcao2.Click += new System.EventHandler(this.btnIlhaOpcao2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolha uma opção de ilha!";
            // 
            // frmEscolherIlha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 163);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIlhaOpcao2);
            this.Controls.Add(this.btnIlhaOpcao1);
            this.Name = "frmEscolherIlha";
            this.Text = "frmEscolherIlha";
            this.Load += new System.EventHandler(this.frmEscolherIlha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIlhaOpcao1;
        private System.Windows.Forms.Button btnIlhaOpcao2;
        private System.Windows.Forms.Label label1;
    }
}