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

                    Partida partida = new Partida(idPartida, nome, senha);
                    Jogador jogador = new Jogador(partida, this.idJogador, nome, senhaJogador, false);

                    jogador.marcador = Properties.Resources.agua;


                    frmJogo frmJogo = new frmJogo(jogador, partida);

                    frmJogo.Show();
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

        private void txtSenhaa_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCriarPartida_MouseEnter(object sender, EventArgs e)
        {
            btnCriarPartida.Image = Properties.Resources.criar2;
            btnCriarPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }

        private void btnCriarPartida_MouseLeave(object sender, EventArgs e)
        {
            btnCriarPartida.Image = Properties.Resources.criar1;
            btnCriarPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }

        private void btnListar_MouseEnter(object sender, EventArgs e)
        {
            btnListarPartidas.Image = Properties.Resources.listar2;
            btnListarPartidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }

        private void btnListar_MouseLeave(object sender, EventArgs e)
        {
            btnListarPartidas.Image = Properties.Resources.listar1;
            btnListarPartidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }

        private void btnEntrar_MouseEnter(object sender, EventArgs e)
        {
            btnEntrarPartida.Image = Properties.Resources.entrar2;
            btnEntrarPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        {
            btnEntrarPartida.Image = Properties.Resources.entrar1;
            btnEntrarPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }
    }
}
