using System;
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
            this.MaximizeBox = false;
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {

            lstPartidas.Items.Clear();
            string strPartidas = Jogo.ListarPartidas("T");
            string[] arrPartidas = strPartidas.Split('\n');
            Array.Reverse(arrPartidas);

            foreach (string partida in arrPartidas)
            {
                if (partida != "")
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
                frmMessageBox popup = new frmMessageBox("Aviso", "Partida criada com sucesso!");
                popup.ShowDialog();
            }
            else
            {
                status.Replace("ERRO:", "");
                frmMessageBox popup = new frmMessageBox("Erro", status);
                popup.ShowDialog();
            }

            btnListarPartidas.PerformClick();
            lstPartidas.SelectedIndex = 0;
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            if (lstPartidas.SelectedItem != null)
            {
                string partidaSelecionada = lstPartidas.SelectedItem.ToString();
                string[] arrPartida = partidaSelecionada.Split(',');

                string idPartida = arrPartida[0];
                string nomePartida = arrPartida[1];

                string nome = txtNomeJogador.Text;
                string senha = txtSenhaa.Text;
                string status = Jogo.EntrarPartida(Int32.Parse(idPartida), nome, senha);

                if (!(status.Contains("ERRO")))
                {
                    string[] arrStatus = status.Split(',');
                    this.idJogador = arrStatus[0];
                    this.senhaJogador = arrStatus[1];

                    Partida partida = new Partida(idPartida, nomePartida, senha);
                    Jogador jogador = new Jogador(partida, this.idJogador, nome, senhaJogador, false);

                    jogador.marcador = Properties.Resources.agua;

                    this.Visible = false;
                    frmJogo frmJogo = new frmJogo(jogador, partida);
                    frmJogo.ShowDialog();
                    this.Visible = true;
                
                }
                else
                {
                    frmMessageBox popup = new frmMessageBox("Erro", status);
                    popup.ShowDialog();
                }
            }
            else
            {
                frmMessageBox popup = new frmMessageBox("Erro", "Não há nenhuma partida selecionada!");
                popup.ShowDialog();
            }
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
