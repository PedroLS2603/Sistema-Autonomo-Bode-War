using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piBodeWar.model
{
    internal class Estrategia
    {
        private Partida partida { get; set; }
        private Jogador jogador { get; set; }

        /* Peso 1 - c ≤ 15; Peso 2 - 15 < c ≤ 40; Peso 3 - 37 < c ≤ 50*/
        private List<Carta> peso1 { get; set; }
        private List<Carta> peso2 { get; set; }
        private List<Carta> peso3 { get; set; }

        private double limiteProximidadeIlha { get; set; }



        public Dictionary<string, double> cenarios;
        public Estrategia(Partida partida, Jogador jogador)
        {
            this.peso1 = new List<Carta>(); // Chance maior de garantir ilhas 
            this.peso2 = new List<Carta>(); //Descarte
            this.peso3 = new List<Carta>(); //Chance maior de garantir bodes
            this.limiteProximidadeIlha = 0.8;

            this.partida = partida;
            this.jogador = jogador;
            this.cenarios = new Dictionary<string, double>();
        }

        public void classificarCartas()
        {
            foreach (Carta c in this.jogador.mao)
            {
                if (c.id <= 15)
                {
                    peso1.Add(c);
                }
                else if (c.id <= 37)
                {
                    peso2.Add(c);
                }
                else
                {
                    peso3.Add(c);
                }
            }
        }
        public Carta escolherCarta()
        {
            
            Rodada rodada = this.partida.rodadaAtual;
            Carta escolhida = null;
            int idRodada = Int32.Parse(rodada.id);
            if (this.jogador.mao.Count > 0)
            {
               

                switch (idRodada)
                {
                    case 1:
                        /*Casos com altas chances de garantir ilha*/
                        escolhida = this.tentaIlhaOuDescarta();
                        break;
                    case 2:
                        escolhida = this.tentaIlhaOuDescarta();
                        break;
                    case 3:
                        escolhida = this.tentaIlhaOuDescarta();
                        break;
                    case 4:
                        escolhida = this.tentaIlhaOuDescarta();
                        break;
                    default:
                        if(!this.passouDoLimite())
                        {
                            escolhida = this.tentaBodeOuDescarta();
                        }
                        else
                        {
                            escolhida = this.descartaMaiorBode();
                        }
                        break;
                }
            }


            return escolhida;
        }

        private Carta tentaIlhaOuDescarta()
        {

            Rodada rodada = this.partida.rodadaAtual;
            Carta escolhida;
            Carta menorNaMao = this.jogador.mao[0];
            bool temCartaMenor = false;
            if (menorNaMao.id <= 5)
            {
                escolhida = this.jogador.mao[0];
                this.removeCarta(escolhida);
            }

            else if (rodada.cartasJogadas.Count > 0)
            {
                foreach (Carta c in rodada.cartasJogadas)
                {
                    if (c.id < menorNaMao.id)
                    {
                        temCartaMenor = true;
                        break;
                    }
                }

                if (!temCartaMenor)
                {
                    escolhida = this.jogador.mao[0];
                    this.removeCarta(escolhida);

                }
                else
                {
                    escolhida = this.descarta();
                    this.removeCarta(escolhida);
                }
            }
            else
            {
                escolhida = this.descarta();
                this.removeCarta(escolhida);
            }

            return escolhida;
        }

        private Carta descarta()
        {
            Carta escolhida = null;
            if(this.peso2.Count > 0)
            {
                escolhida = this.peso2[0];
                this.removeCarta(escolhida);

            }
            else if (this.peso1.Count > 0)
            {
                escolhida = this.peso1[this.peso1.Count / 2];
                this.removeCarta(escolhida);


            }
            else if (this.peso3.Count > 0)
            {
                escolhida = this.peso3[this.peso3.Count / 2];
                this.removeCarta(escolhida);
            }

            return escolhida;
        }

        private Carta tentaBodeOuDescarta()
        {
            Rodada rodada = this.partida.rodadaAtual;
            Carta escolhida = null;
            Carta maiorNaMao = this.jogador.mao[this.jogador.mao.Count - 1];
            bool temCartaMaior = false;
            if (maiorNaMao.id <= 45)
            {

                escolhida = maiorNaMao;
                this.removeCarta(escolhida);

            }

            else if (rodada.cartasJogadas.Count > 0)
            {
                foreach (Carta c in rodada.cartasJogadas)
                {
                    if (c.id > maiorNaMao.id)
                    {
                        temCartaMaior = true;
                        break;
                    }
                }

                if (!temCartaMaior)
                {
                    escolhida = maiorNaMao;
                    this.removeCarta(escolhida);

                }
                else
                {
                    escolhida = this.descartaMaiorBode();
                    this.removeCarta(escolhida);

                }
            }
            else
            {
                escolhida = this.descartaMaiorBode();
                this.removeCarta(escolhida);

            }

            return escolhida;
        }

        private Carta descartaMaiorBode()
        {
            Carta maior = new Carta(0, 0, 5);

            if(this.peso2.Count > 0)
            {
                foreach (Carta carta in this.peso2)
                {
                    if (carta.numBodes > maior.numBodes)
                    {
                        maior = carta;
                    }
                }
                this.removeCarta(maior);

            }
            else if (this.peso1.Count > 0)
            {
                foreach (Carta carta in this.peso1)
                {
                    if (carta.numBodes > maior.numBodes)
                    {
                        maior = carta;
                    }
                }
                this.removeCarta(maior);

            }
            else
            {
                foreach (Carta carta in this.peso3)
                {
                    if (carta.numBodes > maior.numBodes)
                    {
                        maior = carta;
                    }
                }
                this.removeCarta(maior);

            }

            return maior;
        }

        private bool passouDoLimite()
        {
            double cap = 0;
            if (this.partida.tamanhoIlha > 0)
            {
                cap = this.jogador.numBodes / this.partida.tamanhoIlha;
            }
            return cap < this.limiteProximidadeIlha;
        }

        private bool passouDoLimite(Jogador jogador)
        {
            double cap = 0;
            if (this.partida.tamanhoIlha > 0)
            {
                cap = jogador.numBodes / this.partida.tamanhoIlha;
            }
            return cap < this.limiteProximidadeIlha;
        }

        public void removeCarta(Carta c)
        {
            if(c.id <= 15)
            {
                foreach (Carta carta in this.peso1)
                {
                    if (carta.id == c.id)
                    {
                        this.peso1.Remove(carta);
                        return;
                    }
                }
            } else if( c.id <= 37)
            {
                foreach (Carta carta in this.peso2)
                {
                    if (carta.id == c.id)
                    {
                        this.peso2.Remove(carta);
                        return;
                    }
                }
            }
            else
            {
                foreach (Carta carta in this.peso3)
                {
                    if (carta.id == c.id)
                    {
                        this.peso3.Remove(carta);
                        return;
                    }
                }
            }
        }

        public int escolheIlha(int opcao1, int opcao2)
        {
            int maior = opcao1 > opcao2 ? opcao1 : opcao2;
            int menor = opcao1 < opcao2 ? opcao1 : opcao2;
            int countJogadoresQuePassaramDoLimite = 0;
            Dictionary<Jogador, bool> limites = new Dictionary<Jogador, bool>();

            foreach(Jogador jogador in this.partida.jogadores)
            {
                if(jogador.id != this.jogador.id)
                {
                    bool passouLimite = passouDoLimite(jogador);
                    limites.Add(jogador, passouLimite);

                    if (passouLimite) countJogadoresQuePassaramDoLimite++;

                  
                }
            }
            
            if(!passouDoLimite() || countJogadoresQuePassaramDoLimite >= 1)
            {
                return menor;
            }
            else
            {
                return maior;
            }
        }
    }
}
