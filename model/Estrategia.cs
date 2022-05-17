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

        /* Peso 1 - c ≤ 15; Peso 2 - 15 < c ≤ 40; Peso 3 - 40 < c ≤ 50*/
        private List<Carta> peso1 { get; set; }
        private List<Carta> peso2 { get; set; }
        private List<Carta> peso3 { get; set; }



        public Dictionary<string, double> cenarios;
        public Estrategia(Partida partida, Jogador jogador)
        {
            this.peso1 = new List<Carta>(); // Chance maior de garantir ilhas 
            this.peso2 = new List<Carta>(); //Descarte
            this.peso3 = new List<Carta>(); //Chance maior de garantir bodes


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
                else if (c.id <= 40)
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
            Carta menorNaMao = this.jogador.mao[0];
            int idRodada = Int32.Parse(rodada.id);
            bool temCartaMenor;
            if (this.jogador.mao.Count > 0)
            {
               

                switch (idRodada)
                {

                    case 1:
                        temCartaMenor = false;

                        /*Casos com altas chances de garantir ilha*/
                        if(menorNaMao.id <= 5)
                        {
                            escolhida = this.jogador.mao[0];
                            this.peso1.RemoveAt(0);
                        }

                        if(rodada.cartasJogadas.Count > 0)
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
                                this.peso1.RemoveAt(0);
                            }
                            else
                            {
                                escolhida = this.peso2[this.peso2.Count - 2];
                                this.peso2.RemoveAt(this.peso2.Count - 2);
                            }
                        }
                        else
                        {
                            escolhida = this.peso1[1];
                            this.peso1.RemoveAt(1);
                        }
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;

                }
            }

            escolhida = this.jogador.mao[0];

            return escolhida;
        }
    }
}
