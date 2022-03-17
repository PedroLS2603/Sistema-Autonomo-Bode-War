using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BodeOfWarServer;


namespace piBodeWar
{
    public partial class frmJogo : Form
    {
        public frmJogo()
        {
            InitializeComponent();
        }

        private void txtNarracao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNarração_Click(object sender, EventArgs e)
        {
            string idPartida = Class1.idPartidaAtual;
            string narracao = Jogo.ExibirNarracao(Int32.Parse(idPartida));

            txtNarracao.Text = narracao;
        }
    }
}
