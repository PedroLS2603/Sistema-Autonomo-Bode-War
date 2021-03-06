using BodeOfWarServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piBodeWar.model
{
    public class Partida
    {
        public string id { get; private set; }
        public string nome { get; private set; }
        public string senha { get; private set; }
        public List<Jogador> jogadores { get; private set; }
        public Jogador vencedor { get; set; }
        public char status { get; set; }
        public Rodada rodadaAtual { get; private set; }

        public List<Rodada> rodadas { get; private set; }
        public bool iniciou { get; set; }
        public int tamanhoIlha { get; private set; }
        public List<Carta> cartas { get; }
        public Partida(string id, string nome, string senha)
        {
            this.id = id;
            this.nome = nome;
            this.senha = senha;
            this.jogadores = new List<Jogador>();
            this.status = 'A';
            this.cartas = new List<Carta>();
            this.tamanhoIlha = 0;
            string strCartas = Jogo.ListarCartas();
            strCartas.Replace('\r', ' ');
            string[] arrCartas = strCartas.Split('\n');
            this.rodadas = new List<Rodada>();

            foreach (string c in arrCartas)
            {
                string[] arrCarta = c.Split(',');

                if (arrCarta.Length > 1)
                {
                    int num = Int32.Parse(arrCarta[0]);
                    int numBodes = Int32.Parse(arrCarta[1]);
                    int arte = Int32.Parse(arrCarta[2]);
                    Carta carta = new Carta(num, numBodes, arte);

                    this.cartas.Add(carta);
                }
                else
                {
                    break;
                }
            }

        }

        public Carta buscarCarta(int numCarta)
        {
            foreach (Carta carta in this.cartas)
            {
                if (carta.id == numCarta)
                {
                    return carta;
                }
            }
            return null;
        }

        public void setRodadaAtual(Rodada rodada)
        {
            if (rodada != null)
            {
                this.rodadaAtual = rodada;
            }
        }

        public string exibirNarracao()
        {
            string narracao = Jogo.ExibirNarracao(Int32.Parse(this.id));


            narracao = this.formatarNarracao(narracao);

            if (this.rodadaAtual != null)
            {
                this.distribuirBodes(narracao);
            }

            return narracao;
        }

        private string formatarNarracao(string narracao)
        {
            foreach (Jogador jogador in this.jogadores)
            {
                narracao = narracao.Replace($", é a vez de {jogador.nome}", "");
            }

            narracao = narracao.Replace(",", "\n");
            narracao = narracao.Replace("vai colocar um pedaço da ", "definirá a ");
            narracao = narracao.Replace("venceu a rodada e ", "");
            narracao = narracao.Replace("perdeu a rodada e ", "");
            narracao = narracao.Replace("Jogador ", "");

            return narracao;
        }

        public List<Jogador> listarJogadores()
        {
            this.jogadores.Clear();
            string retorno = Jogo.ListarJogadores(Int32.Parse(this.id));
            retorno = retorno.Replace('\r'.ToString(), String.Empty);
            string[] arrRetorno = retorno.Split('\n');

            for (int i = 0; i < arrRetorno.Length; i++)
            {
                string strJogador = arrRetorno[i];
                if (strJogador != "")
                {
                    string[] infoJogador = strJogador.Split(',');
                    string id = infoJogador[0];
                    string nome = infoJogador[1];

                    Jogador jogador = new Jogador(this, id, nome, i + 1);

                    this.jogadores.Add(jogador);
                }
            }

            return this.jogadores;
        }

        public Jogador buscarJogador(string id)
        {
            foreach (Jogador jogador in this.jogadores)
            {
                if (jogador.id == id)
                {
                    return jogador;
                }
            }
            return null;
        }

        public Jogador buscarJogador(int numBodes)
        {
            int countJogador = 0;
            foreach (Jogador jogador in this.jogadores)
            {
                if (jogador.numBodes == numBodes && countJogador == 1)
                {
                    return jogador;
                }
            }
            return null;
        }

        public void setTamanhoIlha(int valor)
        {
            if (valor > 0)
            {
                this.tamanhoIlha = valor;
            }
        }
        public void aumentarIlha(int valor)
        {
            if (valor > 0)
            {
                this.tamanhoIlha += valor;
            }
        }

        public Jogador verificaVencedor()
        {
            int maiorQtdBodes = 0;

            foreach (Jogador jogador in this.jogadores)
            {
                if (jogador.numBodes > maiorQtdBodes && this.tamanhoIlha >= jogador.numBodes)
                {
                    maiorQtdBodes = jogador.numBodes;
                }
            }

            if (maiorQtdBodes == 0)
            {
                int menorQtdBodesAposEstourar = 0;
                foreach (Jogador jogador in this.jogadores)
                {
                    if (menorQtdBodesAposEstourar == 0)
                    {
                        menorQtdBodesAposEstourar = jogador.numBodes;
                    }

                    if (menorQtdBodesAposEstourar < jogador.numBodes)
                    {
                        menorQtdBodesAposEstourar = jogador.numBodes;
                    }
                }
                this.vencedor = this.buscarJogador(menorQtdBodesAposEstourar);
            }
            else
            {
                this.vencedor = this.buscarJogador(maiorQtdBodes);
            }

            return this.vencedor;
        }

        public Rodada obterRodadaPorId(string id)
        {
            foreach (Rodada rodada in this.rodadas)
            {
                if (rodada.id == id)
                {
                    return rodada;
                }
            }
            return null;
        }

        public void encerrar()
        {
            this.status = 'E';
        }

        public void iniciar()
        {
            this.listarJogadores();
            this.iniciou = true;
        }

        public List<Carta> listarTodasAsCartas()
        {
            List<Carta> retorno = new List<Carta>();

            foreach (Carta c in this.cartas)
            {
                retorno.Add(c);
            }

            return retorno;
        }

        public void distribuirBodes(string narracao)
        {
            try
            {
                foreach (Jogador jogador in this.jogadores)
                {
                    int qtdBodes = Util.obterQtdDeBodesPorNarracao(narracao, jogador.nome);

                    jogador.setBodes(qtdBodes);
                }
            }
            catch
            {
                return;
            }
        }
    }
}
