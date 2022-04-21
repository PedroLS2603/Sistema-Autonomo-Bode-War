using piBodeWar.model;
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

namespace piBodeWar.forms
{
    public partial class frmJogo : Form
    {
        public Jogador jogador { get; }
        public Partida partida { get; }


        public List<Carta> listaCarta;
        public frmJogo(Jogador jogador, Partida partida)
        {
            this.jogador = jogador;
            this.partida = partida;
            this.listaCarta = new List<Carta>();
            InitializeComponent();
            this.Text = "Animaniacs";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            string strCartas = Jogo.ListarCartas();
            strCartas.Replace('\r', ' ');
            string[] arrCartas = strCartas.Split('\n');


            foreach (string c in arrCartas)
            {
                string[] arrCarta = c.Split(',');

                if (arrCarta.Length > 1)
                {
                    int num = Int32.Parse(arrCarta[0]);
                    int numBodes = Int32.Parse(arrCarta[1]);
                    int arte = Int32.Parse(arrCarta[2]);
                    Carta carta = new Carta(num, numBodes, arte);

                    this.listaCarta.Add(carta);
                }
                else
                {
                    break;
                }
            }
        }

        private void btnVerMao_Click(object sender, EventArgs e)
        {
            flpMao.Controls.Clear();
            this.jogador.verMao(this.partida);

            int xCarta = 3;
            int yCarta = 50;

            int widthCarta = 114;
            int razaoEspacamento = 50;

       
            flpMao.Visible = false;

            if(this.jogador.mao.Count > 0)
            {
                foreach (Carta c in this.jogador.mao)
                {
                    int xBode = 3;
                    int yBode = 140;

                    Panel pnlCarta = new Panel();
                    pnlCarta.Size = new Size(112, 172);
                    pnlCarta.BackgroundImage = c.imagem;
                    pnlCarta.Location = new Point(xCarta, yCarta);

                    Label label = new Label();
                    label.Text = c.id.ToString();
                    label.BackColor = Color.Transparent;
                    label.ForeColor = Color.White;
                    label.Font = new Font("Microsoft Sans Serif", 15);
                    label.Size = new Size(55, 40);
                    label.Location = new Point(8, 10);
                    pnlCarta.Controls.Add(label);

                    for (int i = 0; i < c.numBodes; i++)
                    {
                        Panel pnlBode = new Panel();
                        pnlBode.Size = new Size(16, 16);
                        pnlBode.BackgroundImage = (Image)Properties.Resources.bode;
                        pnlBode.Location = new Point(xBode, yBode);
                        pnlBode.BackColor = Color.Transparent;
                        pnlCarta.Controls.Add(pnlBode);
                        xBode += 19;
                    }

                    xCarta += widthCarta + razaoEspacamento;
                    flpMao.Controls.Add(pnlCarta);
                }
                flpMao.Visible = true;
            }
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {

            if (this.jogador.id != null && this.jogador.senha != null)
            {
                this.jogador.iniciarPartida(this.partida);
                Jogador quemJoga = this.jogador.verificaVez(this.partida);

                txtStatusRodada.Text = String.Format("Status - vez de {0}", quemJoga.nome);
            }
            else
            {
                txtStatus.Text += "\nVocê não está em nenhuma partida!";
            }
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            Jogador quemJoga =  this.jogador.verificaVez(this.partida);
            if(quemJoga != null)
            {
                txtStatusRodada.Text = String.Format("Status - Vez de {0}", quemJoga.nome);
                if(quemJoga.id == this.jogador.id && this.partida.rodadaAtual.status == 'I')
                {
                    frmEscolherIlha formEscolherIlha = new frmEscolherIlha(this.jogador);

                    formEscolherIlha.ShowDialog();
                }
            }
        }


        private void btnNarracao_Click(object sender, EventArgs e)
        {
            txtStatus.Text = this.partida.exibirNarracao();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnJogarCarta_Click(object sender, EventArgs e)
        {
            this.jogador.jogarCarta();
        }

        private void btnVerificarIlha_Click(object sender, EventArgs e)
        {
            string status = Jogo.VerificarIlha(Int32.Parse(this.jogador.id), this.jogador.senha);

            txtStatus.Text = status;
        }

        private void btnVerificarMesa_Click(object sender, EventArgs e)
        {
            this.jogador.verificarMesa(partida);

            txtStatus.Text = this.partida.rodadaAtual.status.ToString();
            lblIlha.Text = String.Format("Ilha - {0}", this.partida.tamanhoIlha.ToString());
        }
    }
}
