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
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVerMao_Click(object sender, EventArgs e)
        {
            string strCartas = Jogo.VerificarMao(Int32.Parse(this.jogador.id), this.jogador.senha);
            
            
            if(!(strCartas.Contains("ERRO")))
            {
                txtStatus.Text = strCartas;

                int xCarta = 3;
                int yCarta = 50;

                int widthCarta = 114;
                int razaoEspacamento = 50;

                strCartas.Replace('\r', ' ');
                string[] arrCartas = strCartas.Split('\n');

                foreach (string c in arrCartas)
                {

                    if (c != "")
                    {
                        int num = Int32.Parse(c);

                        Carta carta = this.buscarCarta(num);

                        this.jogador.mao.Add(carta);
                    }
                    else { break; }

                }

                foreach (Carta c in this.jogador.mao)
                {
                    int xBode = 3;
                    int yBode = 140;

                    Label label = new Label();
                    label.Text = c.id.ToString();
                    label.BackColor = Color.Transparent;
                    label.ForeColor = Color.White;
                    label.Font = new Font("Microsoft Sans Serif", 15);
                    label.Size = new Size(55, 40);
                    label.Location = new Point(8, 10);

                    Panel pnlCarta = new Panel();
                    pnlCarta.Size = new Size(112, 174);
                    pnlCarta.BackgroundImage = c.imagem;
                    pnlCarta.Location = new Point(xCarta, yCarta);

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

                    pnlCarta.Controls.Add(label);

                    flpMao.Controls.Add(pnlCarta);

                    xCarta += widthCarta + razaoEspacamento;
                }
            }
           

        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {

            if (this.jogador.id != null && this.jogador.senha != null)
            {
                Jogo.IniciarPartida(Int32.Parse(this.jogador.id), this.jogador.senha);
                string strCartas = Jogo.ListarCartas();
                txtStatus.Text = strCartas;
                strCartas.Replace('\r', ' ');
                string[] arrCartas = strCartas.Split('\n');
                

                foreach(string c in arrCartas)
                {
                    string[] arrCarta = c.Split(',');

                    if(arrCarta.Length > 1)
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
            else
            {
                txtStatus.Text += "\nVocê não está em nenhuma partida!";
            }
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            txtStatus.Text += Jogo.VerificarVez(Int32.Parse(this.partida.id));


        }

        private Carta buscarCarta(int numCarta)
        {
            foreach(Carta carta in this.listaCarta) {
                if(carta.id == numCarta)
                {
                    return carta;
                }
            }
            return null;
        }

        private void btnNarracao_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
