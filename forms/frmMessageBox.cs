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
        public frmMessageBox(string titulo, string mensagem)
        {
            InitializeComponent();
            lblMensagem.Text = mensagem;
            this.Text = titulo;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
