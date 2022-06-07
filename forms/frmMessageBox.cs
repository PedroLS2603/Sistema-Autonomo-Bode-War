using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piBodeWar.forms
{
    public partial class frmMessageBox : Form
    {

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        public frmMessageBox(string titulo, string mensagem)
        {
            InitializeComponent();
            lblMensagem.Text = mensagem;
            lblTitulo.Text = titulo;
            this.Text = titulo;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_MouseEnter(object sender, EventArgs e)
        {
            btnOk.Image = Properties.Resources.ok11;
            btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }

        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            btnOk.Image = Properties.Resources.ok2;
            btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }
    }
}
