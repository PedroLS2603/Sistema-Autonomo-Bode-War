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

        public frmJogo(Jogador jogador, Partida partida)
        {
            this.jogador = jogador;
            this.partida = partida;
            InitializeComponent();
            this.Text = "Animaniacs";
            tmrMinhaVez.Enabled = true;

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
                lblStatusRodada.Text = String.Format("Status - Vez de {0}", quemJoga.nome);
                for (int i = 0; i < this.partida.jogadores.Count; i++)
                {
                    Jogador jogador = this.partida.jogadores[i];
                    if (jogador.id == this.jogador.id)
                    {
                        this.jogador.marcador = jogador.marcador;
                    }
                    switch (i)
                    {
                        case 0:
                            lblJogador1.Text = jogador.nome;
                            break;
                        case 1:
                            lblJogador2.Text = jogador.nome;
                            break;
                        case 2:
                            lblJogador3.Text = jogador.nome;
                            break;
                        case 3:
                            lblJogador4.Text = jogador.nome;
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
            Jogador quemJoga = this.jogador.verificaVez(this.partida);
            if (quemJoga != null)
            {
                lblStatusRodada.Text = String.Format("Status - Vez de {0}", quemJoga.nome);
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
        }

        private void mostraMao()
        {
            if (this.jogador.mao.Count > 0)
            {
                flpMao.Controls.Clear();
                foreach (Carta c in this.jogador.mao)
                {
                    int xBode = 3;
                    int yBode = 160;

                    Panel pnlCarta = new Panel();
                    pnlCarta.Size = new Size(100, 206);
                    pnlCarta.BackgroundImage = c.imagem;

                    Label label = new Label();
                    label.Text = c.id.ToString();
                    label.BackColor = Color.Transparent;
                    label.ForeColor = Color.White;
                    label.Font = new Font("Microsoft Sans Serif", 15);
                    label.Size = new Size(55, 40);
                    label.Location = new Point(3, 35);
                    pnlCarta.Controls.Add(label);

                    Panel indicadorCor = new Panel();
                    indicadorCor.Size = new Size(25, 25);
                    indicadorCor.Location = new Point(35, 8);
                    indicadorCor.BackgroundImage= c.detentor.marcador;
                    pnlCarta.Controls.Add(indicadorCor);

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

        public void mostraMesa()
        {
            lblIlha.Text = String.Format("Ilha - {0}", partida.tamanhoIlha.ToString());

            if (this.partida.rodadaAtual.cartasJogadas.Count > 0)
            {
                flpMesa.Controls.Clear();
                foreach (Carta c in this.partida.rodadaAtual.cartasJogadas)
                {
                    int xBode = 3;
                    int yBode = 160;

                    Panel pnlCarta = new Panel();
                    pnlCarta.Size = new Size(100, 206);
                    pnlCarta.BackgroundImage = c.imagem;

                    Label label = new Label();
                    label.Text = c.id.ToString();
                    label.BackColor = Color.Transparent;
                    label.ForeColor = Color.White;
                    label.Font = new Font("Microsoft Sans Serif", 15);
                    label.Size = new Size(55, 40);
                    label.Location = new Point(3, 35);
                    pnlCarta.Controls.Add(label);

                    Panel indicadorCor = new Panel();
                    indicadorCor.Size = new Size(25, 25);
                    indicadorCor.Location = new Point(35, 8);
                    indicadorCor.BackgroundImage = c.detentor.marcador;
                    pnlCarta.Controls.Add(indicadorCor);

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
                lblBodes.Text = String.Format("Meus bodes - {0}", this.partida.buscarJogador(this.jogador.id).numBodes.ToString());
                lblBodesRodada.Text = $"Bodes rodada - {partida.rodadaAtual.totalBodes}";
            }
        }
        /**Timer**/
        private void tmrMinhaVez_Tick(object sender, EventArgs e)
        {

            tmrMinhaVez.Enabled = false;
            this.mostraMao();
            Jogador quemJoga = this.jogador.verificaVez(this.partida);

            if(quemJoga != null)
            {
                lblStatusRodada.Text = String.Format("Status - vez de {0}", quemJoga.nome);
                if (!this.partida.iniciou)
                {
                    this.partida.listarJogadores();
                    this.jogador.verMao(this.partida);
                    this.partida.setRodadaAtual(new Rodada("1", 'B', 0, this.partida));

                    for (int i = 0; i < this.partida.jogadores.Count; i++)
                    {
                        Jogador jogador = this.partida.jogadores[i];
                        if (jogador.id == this.jogador.id)
                        {
                            this.jogador.marcador = jogador.marcador;
                        }
                        switch (i)
                        {
                            case 0:
                                lblJogador1.Text = jogador.nome;
                                break;
                            case 1:
                                lblJogador2.Text = jogador.nome;
                                break;
                            case 2:
                                lblJogador3.Text = jogador.nome;
                                break;
                            case 3:
                                lblJogador4.Text = jogador.nome;
                                break;
                        }
                    }
                    this.partida.iniciou = true;
                }

                else if (this.partida.rodadaAtual.status == 'E' && this.partida.rodadaAtual.id == "8")
                {
                    this.jogador.verificarMesa(this.partida, 8);
                    this.mostraMesa();
                    this.flpMao.Controls.Clear();
                    this.jogador.encerrarPartida(this.partida);
                    Jogador vencedor = this.partida.vencedor;

                    string mensagem = "Partida encerrada!";
                    tmrMinhaVez.Enabled = false;
                    if (vencedor != null)
                    {
                        mensagem += String.Format("\n{0} venceu!", vencedor.nome);
                    }

                    DialogResult resultado = MessageBox.Show(mensagem, "Resultado");
                    if (resultado == DialogResult.OK)
                    {
                        //this.Close();
                        return;
                    }
                }
                
                if (quemJoga.id == this.jogador.id)
                {

                    switch (this.partida.rodadaAtual.status)
                    {
                        case 'B':
                            this.jogador.jogarCarta();
                            break;
                        case 'I':
                            this.jogador.escolherIlha();
                            break;
                        case 'E':
                            return;
                    }
                }
                this.jogador.verificarMesa(this.partida);
                this.mostraMesa();
                lblRodada.Text = $"Rodada - {this.partida.rodadaAtual.id}";
            }

            tmrMinhaVez.Enabled = true;

        }

        private void flpMao_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmJogo_Load(object sender, EventArgs e)
        {

        }

        private void lblIlha_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblJogador2_Click(object sender, EventArgs e)
        {

        }
    }
}

