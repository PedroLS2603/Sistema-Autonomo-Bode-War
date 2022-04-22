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
        public string id {get; private set;}
        public string nome {get; private set;}
        public string senha { get; private set;}
        public List<Jogador> jogadores { get; private set;}
        public Jogador vencedor { get; set;}
        public char status { get; set;}
        public Rodada rodadaAtual { get; private set; }
        public bool iniciou { get;  set; }
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
            if(rodada != null)
            {
                this.rodadaAtual = rodada;
            }
        }

        public string exibirNarracao()
        {
            string narracao = Jogo.ExibirNarracao(Int32.Parse(this.id));

            return narracao;
        }

        public List<Jogador> listarJogadores()
        {
            this.jogadores.Clear();
            string retorno = Jogo.ListarJogadores(Int32.Parse(this.id));
            retorno = retorno.Replace('\r'.ToString(), String.Empty);
            string[] arrRetorno = retorno.Split('\n');

            foreach(string strJogador in arrRetorno)
            {
                if(strJogador != "")
                {
                    string[] infoJogador = strJogador.Split(',');
                    string id = infoJogador[0];
                    string nome = infoJogador[1];

                    Jogador jogador = new Jogador(id, nome);

                    this.jogadores.Add(jogador);
                }
            }

            return this.jogadores;
        }

        public Jogador buscarJogador(string id)
        {
            foreach (Jogador jogador in this.jogadores)
            {
                if(jogador.id == id)
                {
                    return jogador;
                }
            }
            return null;
        }

        public void setTamanhoIlha(int valor)
        {
            if(valor > 0)
            {
                this.tamanhoIlha = valor;
            }
        }
        public void aumentarIlha(int valor)
        {
            if(valor > 0)
            {
                this.tamanhoIlha += valor;
            }
        }
    }
}
