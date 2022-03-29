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
            txtStatus.Text = strCartas;

            strCartas.Replace('\r', ' ');
            string[] arrCartas = strCartas.Split('\n');

            foreach(string c in arrCartas)
            {

                if(c != "")
                {
                    int num = Int32.Parse(c);

                    Carta carta = this.buscarCarta(num);

                    this.jogador.mao.Add(carta);
                }
                else { break; }
                
            }
            /*PictureBox imageControl = newPictureBox();  
            imageControl.Width = 400;  
            imageControl.Height = 400;  
            Bitmap image = newBitmap("C:\\Images\\Creek.jpg");  
            imageControl.Dock = DockStyle.Fill;  
            imageControl.Image = (Image) image;  
            Controls.Add(imageControl);  */
            int x, y;
            x = 238;
            y = 333;
            foreach (Carta c in this.jogador.mao)
            {
                PictureBox picBox = new PictureBox();
                picBox.Location = new Point(x, y);
                Bitmap imagem = new Bitmap(Image.FromFile(c.imagem));
                picBox.BackgroundImage = imagem;

                x += 87;

                Controls.Add(picBox);
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
    }
}
