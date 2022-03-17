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
    public partial class Form1 : Form
    {
        private string senhaJogador;
        private string idJogador;
        private string idPartidaAtual = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {

            lstPartidas.Items.Clear();
            string strPartidas = Jogo.ListarPartidas("T");
            string[] arrPartidas = strPartidas.Split('\n');
            // partidas.Replace();

            for (int i = 0; i < arrPartidas.Length; i++)
            {
                lstPartidas.Items.Add(arrPartidas[i]);

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstJogadores_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string senha = txtSenha.Text;
            string status = Jogo.CriarPartida(nome, senha);

            if (status.Length <= 4)
            {
                status = "Partida criada com sucesso!";
            }

            txtStatus.Text = status;

        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            lstJogadores.Items.Clear();
            string idPartida = lstPartidas.SelectedItem.ToString();
            string[] arrPartida = idPartida.Split(',');

            idPartida = arrPartida[0];

            string strJogadores = Jogo.ListarJogadores(Int32.Parse(idPartida));

            string[] arrJogadores = strJogadores.Split('\n');


            for (int i = 0; i < arrJogadores.Length; i++)
            {
                lstJogadores.Items.Add(arrJogadores[i]);
            }
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            string idPartida = lstPartidas.SelectedItem.ToString();
            string[] arrPartida = idPartida.Split(',');

            idPartida = arrPartida[0];
            this.idPartidaAtual = idPartida;

            string idJogador = txtNomeJogador.Text;
            string senha = txtSenhaa.Text;

            string status = Jogo.EntrarPartida(Int32.Parse(idPartida), idJogador, senha);

            if(status.Substring(0, 4) != "ERRO")
            {
                string[] arrStatus = status.Split(',');
                Class1.idJogador = arrStatus[0];
                Class1.senhaJogador = arrStatus[1];
                Class1.idPartidaAtual = idPartida;


                txtStatus.Text = "Entrada realizada com sucesso!";
                frmJogo formJogo = new frmJogo();
                formJogo.Show();
            }
            else
            {
                txtStatus.Text = status;
            }

        }
        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {

            if(this.idJogador != null && this.senhaJogador != null)
            {
              Jogo.IniciarPartida(Int32.Parse(this.idJogador), this.senhaJogador);
            }
            else
            {
                txtStatus.Text = "Você não está em nenhuma partida!";
            }

        }

        private void btnMostrarVez_Click(object sender, EventArgs e)
        {
            string status;
            if (this.idPartidaAtual != null)
            {
                status = Jogo.VerificarVez(Int32.Parse(this.idPartidaAtual));

            } else
            {
                status = "Você não está em nenhuma partida!";
            }

            if (status.Substring(0, 4) != "ERRO") {
                string[] arrStatus = status.Split(',');
                txtStatus.Text = String.Format("É a vez do jogador {0}", arrStatus[1]);
            }
            else
            {
                txtStatus.Text = status;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
