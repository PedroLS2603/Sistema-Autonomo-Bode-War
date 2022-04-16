using BodeOfWarServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piBodeWar.model
{
    public class Jogador
    {
        public string id { get; }
        public string nome { get; }
        public string senha { get; }
        public int numBodes { get; private set; }
        public bool isBot { get; set; }
        public List<Carta> mao { get; }


        public Jogador(string id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
        public Jogador(string id, string nome, string senha, bool isBot)
        {
            this.id = id;
            this.nome = nome;
            this.senha = senha;
            this.mao = new List<Carta>();
            this.numBodes = 0;
            this.isBot = isBot;
        }

        public void jogarCarta()
        {
            Carta escolhida = this.escolherCarta();

            Jogo.Jogar(Int32.Parse(this.id), this.senha, escolhida.id);
        }

        public Carta escolherCarta()
        {

            return mao[0];
        }

        public bool verificaVez(Partida partida)
        {
            string retorno = Jogo.VerificarVez(Int32.Parse(partida.id));
            string[] arrRetorno = retorno.Split(',');
            string statusPartida = arrRetorno[0];
            string idJogador = arrRetorno[1];
            partida.status = statusPartida[0];

            if (partida.status == 'J' && idJogador == this.id )
            {
                if(partida.rodadaAtual.status == 'B')
                {
                    this.jogarCarta();
                }
                else if(partida.rodadaAtual.status == 'I')
                {
                    this.escolherIlha();
                }

                return true;
            }

            return false;
        }

        public List<Carta> verMao(Partida partida)
        {
            string strCartas = Jogo.VerificarMao(Int32.Parse(this.id), this.senha);

            if (!(strCartas.StartsWith("ERRO")))
            
                strCartas.Replace('\r', ' ');
                string[] arrCartas = strCartas.Split('\n');

                foreach (string c in arrCartas)
                {

                    if (c != "")
                    {
                        int num = Int32.Parse(c);

                        Carta carta = partida.buscarCarta(num);

                        this.mao.Add(carta);
                    }
                    else { break; }

                }
            return this.mao;
        }

        public void escolherIlha() {
            string retorno = Jogo.VerificarIlha(Int32.Parse(this.id), this.senha);
            string[] opcoesIlha = retorno.Split(',');

            Jogo.DefinirIlha(Int32.Parse(this.id), this.senha, Int32.Parse(opcoesIlha[0]));
        }

        public void verificarMesa(Partida partida)
        {
            string status = Jogo.VerificarMesa(Int32.Parse(partida.id));

            status.Replace("I", "");

            string[] arrStatus = status.Split('\n');

            
            for(int i = 1; i < arrStatus.Length; i++)
            {
                Carta carta = partida.buscarCarta(Int32.Parse(arrStatus[i]));

                partida.rodadaAtual.cartasJogadas.Add(carta);
            }
        }

        public void iniciarPartida(Partida partida)
        {
            Jogo.IniciarPartida(Int32.Parse(this.id), partida.senha);
            partida.status = 'J';
        }

        public void adicionarBodes(int valor)
        {
            if(valor > 0)
            {
                this.numBodes += valor;
            }
        }

        public void entrarNaPartida(Partida partida)
        {
            Jogo.EntrarPartida(Int32.Parse(partida.id), this.nome, this.senha);
        }
    }
}
