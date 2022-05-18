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

        private Estrategia inteligencia { get; set; }

        private Partida partida { get; set; }

        public System.Drawing.Color cor;
        public Jogador(Partida partida, string id, string nome, int cor)
        {
            this.id = id;
            this.nome = nome;
            this.partida = partida;
            switch(cor)
            {
                case 1:
                    this.cor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Yellow);
                    break;
                case 2:
                    this.cor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Blue);
                    break;
                case 3:
                    this.cor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Green);
                    break;
                case 4:
                    this.cor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Red);
                    break;
            }
        }
        public Jogador(Partida partida, string id, string nome, string senha, bool isBot)
        {
            this.id = id;
            this.nome = nome;
            this.senha = senha;
            this.mao = new List<Carta>();
            this.numBodes = 0;
            this.isBot = isBot;
            this.cor = System.Drawing.Color.Yellow;
            this.partida = partida;
            this.inteligencia = new Estrategia(this.partida, this);
        }

        public void jogarCarta()
        {
            Carta escolhida = this.escolherCarta();

            if(escolhida != null && escolhida.id > 0)
            {
                Jogo.Jogar(Int32.Parse(this.id), this.senha, escolhida.id);
                int indice = obterIndiceDaMao(escolhida);
                if(indice > -1)
                {
                    this.mao.RemoveAt(indice);
                }
            }
        }

        public Carta escolherCarta()
        {

            return this.inteligencia.escolherCarta();
        }

        public Jogador verificaVez(Partida partida)
        {
            string retorno = Jogo.VerificarVez(Int32.Parse(partida.id));
            retorno = retorno.Replace('\r'.ToString(), "");
            retorno = retorno.Replace('\n'.ToString(), "");

            Jogador quemJoga;

            if (retorno.StartsWith("ERRO"))
            {
                quemJoga = null;
            }
            else {
                string[] arrRetorno = retorno.Split(',');
                string statusPartida = arrRetorno[0];
                string idJogador = arrRetorno[1];
                string idRodada = arrRetorno[2];   
                char statusRodada = arrRetorno[3][0];
                partida.status = statusPartida[0];
                switch (idRodada)
                {
                    case "1":
                        partida.listarJogadores();
                        break;
                    case "8":
                        this.partida.vencedor = this.partida.buscarJogador(idJogador);
                        this.encerrarPartida(this.partida);
                        break;
                }
                if (partida.rodadaAtual != null && statusRodada == 'B' && idRodada != partida.rodadaAtual.id)
                {
                    partida.rodadas.Add(partida.rodadaAtual);
                    partida.setRodadaAtual(new Rodada(idRodada, statusRodada, 0, partida));
                }
                else if(partida.rodadaAtual != null && idRodada == partida.rodadaAtual.id)
                {
                    partida.rodadaAtual.setStatus(statusRodada);
                    if(statusRodada == 'E' && idRodada == "8")
                {
                    return this.partida.vencedor;
                }

                }
                

                quemJoga = partida.buscarJogador(idJogador);
            }


            return quemJoga;
        }

        public List<Carta> verMao(Partida partida)
        {
            string strCartas = Jogo.VerificarMao(Int32.Parse(this.id), this.senha);

            if (!(strCartas.StartsWith("ERRO")))
                this.mao.Clear();
                   
                strCartas.Replace('\r'.ToString(), String.Empty);
                string[] arrCartas = strCartas.Split('\n');

                foreach (string c in arrCartas)
                {

                    if (c != "")
                    {
                        int num = Int32.Parse(c);

                        Carta carta = partida.buscarCarta(num);
                        carta.setDono(this);
                        this.mao.Add(carta);
                    }
                    else { break; }

                }
            if(!partida.iniciou)
            {
                this.inteligencia.classificarCartas();
            }

            return this.mao;
        }

        public void escolherIlha() {
            string retorno = Jogo.VerificarIlha(Int32.Parse(this.id), this.senha);
            string[] opcoesIlha = retorno.Split(',');
            int escolha = this.inteligencia.escolheIlha(Int32.Parse(opcoesIlha[0]), Int32.Parse(opcoesIlha[1]));

            Jogo.DefinirIlha(Int32.Parse(this.id), this.senha, escolha);
        }

        public void verificarMesa(Partida partida, int idRodada = 0)
        {
            partida.rodadaAtual.cartasJogadas.Clear();
            string status;

            if (idRodada == 0)
            {
                if (Int32.Parse(partida.rodadaAtual.id) >= 4 && Int32.Parse(partida.rodadaAtual.id) < 9)
                {
                    status = Jogo.VerificarMesa(Int32.Parse(partida.id), Int32.Parse(partida.rodadaAtual.id) - 1);
                }
                else
                {
                    status = Jogo.VerificarMesa(Int32.Parse(partida.id));
                }
            }
            
            else
            {
                partida.setRodadaAtual(new Rodada(idRodada.ToString(), 'B', 0, partida));
                status = Jogo.VerificarMesa(Int32.Parse(partida.id), idRodada);
            }
            
            


            status = status.Replace('\r'.ToString(), String.Empty);
            string[] arrStatus = status.Split('\n');

            foreach (string jogada in arrStatus)
            {
                if(jogada.StartsWith("I"))
                {
                    string tamanhoIlha = jogada.Replace("I", "");
                    partida.setTamanhoIlha(Int32.Parse(tamanhoIlha));
                }
                else if(jogada != "")
                {
                    string[] arrJogada = jogada.Split(',');
                    string idJogador = arrJogada[0];
                    string idCarta = arrJogada[1];
                    Carta carta = partida.buscarCarta(Int32.Parse(idCarta));

                    carta.setDono(partida.buscarJogador(idJogador));
                    partida.rodadaAtual.cartasJogadas.Add(carta);
                    partida.rodadaAtual.adicionarBodes(carta.numBodes);
                }
            }
            if (partida.rodadaAtual.cartasJogadas.Count == partida.jogadores.Count && partida.status != 'E' && !partida.rodadaAtual.distribuiuPremio)
            {
                partida.rodadaAtual.distribuirPremios();
            }
        }
        public void iniciarPartida(Partida partida)
        {
            partida.listarJogadores();
            string retorno = Jogo.IniciarPartida(Int32.Parse(this.id), this.senha);

            if(!(retorno.StartsWith("ERRO")))
            {
                partida.setRodadaAtual(new Rodada("1", 'B', 0, partida));
                partida.status = 'J';
                this.verMao(partida);
                partida.iniciou = true;
            }

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

        public void encerrarPartida(Partida partida)
        {
            partida.encerrar();
        }
        
        private int obterIndiceDaMao(Carta carta)
        {
            foreach(Carta c in this.mao)
            {
                if (c.id == carta.id)
                {
                    return this.mao.IndexOf(c);
                }
            }

            return -1;
        }
    }

}
