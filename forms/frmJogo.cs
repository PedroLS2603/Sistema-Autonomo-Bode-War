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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
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
            tmrStatusPartida.Enabled = true;

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


            this.mostraMao();
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
            Jogador quemJoga = this.jogador.verificaVez(this.partida);
            if (quemJoga != null)
            {
                txtStatusRodada.Text = String.Format("Status - Vez de {0}", quemJoga.nome);
                if (quemJoga.id == this.jogador.id && this.partida.rodadaAtual.status == 'I')
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

        }

        private void btnVerificarMesa_Click(object sender, EventArgs e)
        {
            this.jogador.verificarMesa(partida);
            this.atualizarTela();
        }

        private void atualizarTela()
        {
            lblIlha.Text = String.Format("Ilha - {0}", this.partida.tamanhoIlha.ToString());
            Jogador quemJoga = this.jogador.verificaVez(this.partida);

            if (quemJoga != null)
            {
                txtStatusRodada.Text = String.Format("Status - Vez de {0}", quemJoga.nome);
            }

            flpMao.Visible = false;

            this.mostraMao();
           // this.mostraMesa();
        }

        private void mostraMao()
        {
            if (this.jogador.mao.Count > 0)
            {
                flpMao.Controls.Clear();
                foreach (Carta c in this.jogador.mao)
                {
                    int xBode = 3;
                    int yBode = 140;

                    Panel pnlCarta = new Panel();
                    pnlCarta.Size = new Size(112, 172);
                    pnlCarta.BackgroundImage = c.imagem;

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

                    flpMao.Controls.Add(pnlCarta);
                }
                flpMao.Visible = true;
            }
        }

        private void mostraMesa()
        {
            lblIlha.Text = String.Format("Ilha - {0}", this.partida.tamanhoIlha.ToString());

            if (this.partida.rodadaAtual.cartasJogadas.Count > 0)
            {
                flpMesa.Controls.Clear();
                foreach (Carta c in this.partida.rodadaAtual.cartasJogadas)
                {
                    int xBode = 3;
                    int yBode = 140;

                    Panel pnlCarta = new Panel();
                    pnlCarta.Size = new Size(112, 172);
                    pnlCarta.BackgroundImage = c.imagem;

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

                    flpMesa.Controls.Add(pnlCarta);
                }
                flpMesa.Visible = true;
            }
        }
        /**Timers**/
        private void tmrStatusPartida_Tick(object sender, EventArgs e)
        {
            string retorno = Jogo.VerificarVez(Int32.Parse(this.partida.id));

            if (!retorno.StartsWith("ERRO"))
            {
                if (!this.partida.iniciou)
                {
                    this.partida.listarJogadores();
                    this.jogador.verMao(this.partida);
                    this.partida.setRodadaAtual(new Rodada("1", 'B', 0, this.partida));
                    tmrAtualizaMao.Enabled = true;
//                    tmrAtualizaMesa.Enabled = true;
                    tmrMinhaVez.Enabled = true;
                    this.partida.iniciou = true;
                }
            }
            else
            {
                string status = Jogo.ListarPartidas("E");
                string[] partidas = status.Split('\n');
                
                foreach(string strPartida in partidas)
                {
                    if(strPartida != "")
                    {
                        string[] arrPartida = strPartida.Split(',');

                        string idPartida = arrPartida[0];
                        if (idPartida == this.partida.id)
                        {
                            Jogador vencedor = this.partida.verificaVencedor();
                            string mensagem = "Partida encerrada!";
                            tmrStatusPartida.Enabled = false;
                            tmrMinhaVez.Enabled = false;
                            tmrAtualizaMao.Enabled = false;
//                            tmrAtualizaMesa.Enabled = false;
                            if(vencedor != null)
                            {
                                mensagem += String.Format("\n {0} venceu!", vencedor.nome);
                            }
                            else
                            {
                                mensagem += "\n Empate!";
                            }

                            DialogResult resultado = MessageBox.Show(mensagem, "Resultado");
                            if(resultado == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                    }
                }
                
            }
        }

        private void tmrAtualizaTela_Tick(object sender, EventArgs e)
        {
            this.atualizarTela();
        }

        private void tmrMinhaVez_Tick(object sender, EventArgs e)
        {
            this.jogador.verificarMesa(this.partida);
            this.mostraMesa();

            Jogador quemJoga = this.jogador.verificaVez(this.partida);

            if (quemJoga != null && quemJoga.id == this.jogador.id)
            {
                if (this.partida.rodadaAtual.status == 'B')
                {
                    this.jogador.jogarCarta();
                }
                else
                {
                    this.jogador.escolherIlha();
                }
            }
            
            lblBodes.Text = String.Format("Meus bodes - {0}", this.partida.buscarJogador(this.jogador.id).numBodes.ToString());
        }

        private void tmrAtualizaMesa_Tick(object sender, EventArgs e)
        {
            this.jogador.verificarMesa(this.partida);

            this.mostraMesa();
        }
    }
}
