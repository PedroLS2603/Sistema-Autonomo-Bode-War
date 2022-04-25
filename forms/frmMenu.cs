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
using piBodeWar.forms;
using piBodeWar.model;

namespace piBodeWar
{
    public partial class frmMenu : Form
    {
        private string senhaJogador;
        private string idJogador;
        public frmMenu()
        {
            InitializeComponent();
            this.Text = "Animaniacs - Menu";
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {

            lstPartidas.Items.Clear();
            string strPartidas = Jogo.ListarPartidas("T");
            string[] arrPartidas = strPartidas.Split('\n');
            Array.Reverse(arrPartidas);

            foreach (string partida in arrPartidas)
            {
                if(partida != "")
                {
                    lstPartidas.Items.Add(partida);
                }

            }

        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string senha = txtSenha.Text;
            string status = Jogo.CriarPartida(nome, senha);

            if (!(status.Contains("ERRO")))
            {
                MessageBox.Show("Partida criada com sucesso!");
            } else
            {
                MessageBox.Show(status);
            }

            btnListarPartidas.PerformClick();
            lstPartidas.SelectedIndex = 0;


        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            
            try
            {
                string idPartida = lstPartidas.SelectedItem.ToString();
                string[] arrPartida = idPartida.Split(',');

                idPartida = arrPartida[0];

                string nome = txtNomeJogador.Text;
                string senha = txtSenhaa.Text;
                string status = Jogo.EntrarPartida(Int32.Parse(idPartida), nome, senha);

                if (!(status.Contains("ERRO")))
                {
                    string[] arrStatus = status.Split(',');
                    this.idJogador = arrStatus[0];
                    this.senhaJogador = arrStatus[1];

                    Jogador jogador = new Jogador(this.idJogador, nome, senhaJogador, false);
                    Partida partida = new Partida(idPartida, nome, senha);


                    frmJogo frmJogo = new frmJogo(jogador, partida);

                    frmJogo.ShowDialog();
                }
                else
                {
                    MessageBox.Show(status);
                }
            } catch (Exception error)
            {
                MessageBox.Show(error.Message); 
            }

            }

        private void btnMostrarVez_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
