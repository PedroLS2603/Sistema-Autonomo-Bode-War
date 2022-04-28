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
using piBodeWar.model;

namespace piBodeWar.forms
{
    public partial class frmEscolherIlha : Form
    {
        private Jogador jogador {get; set;}
        public frmEscolherIlha(Jogador jogador)
        {
            this.jogador = jogador;
            InitializeComponent();
            this.Text = "Escolher ilha";
        }

        private void frmEscolherIlha_Load(object sender, EventArgs e)
        {
            string retorno = Jogo.VerificarIlha(Int32.Parse(this.jogador.id), this.jogador.senha);

            string[] opcoesIlha = retorno.Split(',');
            btnIlhaOpcao1.Text = opcoesIlha[0];
            btnIlhaOpcao2.Text = opcoesIlha[1];
        }

        private void btnIlhaOpcao1_Click(object sender, EventArgs e)
        {
            Jogo.DefinirIlha(Int32.Parse(this.jogador.id), this.jogador.senha, Int32.Parse(btnIlhaOpcao1.Text));
            this.Close();
        }

        private void btnIlhaOpcao2_Click(object sender, EventArgs e)
        {
            Jogo.DefinirIlha(Int32.Parse(this.jogador.id), this.jogador.senha, Int32.Parse(btnIlhaOpcao2.Text));
            this.Close();
        }

    }
}
