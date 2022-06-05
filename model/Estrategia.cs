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

        /* Peso 1 - c ≤ 15; Peso 2 - 15 < c ≤ 35; Peso 3 - 37 < c ≤ 50*/
        private List<Carta> peso1 { get; set; }
        private List<Carta> peso2 { get; set; }
        private List<Carta> peso3 { get; set; }

        private double limiteProximidadeIlha { get; set; }

        private int ilhasDefinidas { get; set; }

        public Dictionary<string, double> cenarios;
        public Estrategia(Partida partida, Jogador jogador)
        {
            this.peso1 = new List<Carta>(); // Chance maior de garantir ilhas 
            this.peso2 = new List<Carta>(); //Descarte
            this.peso3 = new List<Carta>(); //Chance maior de garantir bodes
            this.limiteProximidadeIlha = 60.0;
            this.ilhasDefinidas = 0;

            this.partida = partida;
            this.jogador = jogador;
        }

        public void classificarCartas()
        {
            this.peso1 = this.jogador.mao.Where(c => c.id <= 16).ToList();
            this.peso2 = this.jogador.mao.Where(c => c.id <= 34 && c.id > 16).ToList();
            this.peso3 = this.jogador.mao.Where(c => c.id <= 50 && c.id > 34).ToList();

        }
        public Carta escolherCarta()
        {
            
            Rodada rodada = this.partida.rodadaAtual;
            Carta escolhida = null;
            int idRodada = Int32.Parse(rodada.id);
            if (this.jogador.mao.Count > 0)
            {
                if (Int32.Parse(rodada.id) <= 4)
                {
                    if(this.ilhasDefinidas <= 2)
                    {
                        escolhida = this.tentaIlhaOuDescarta();
                    }
                    else {
                        escolhida = this.descarta();
                    }
                }
                else
                {
                    if (!this.passouDoLimite())
                    {
                        escolhida = this.tentaBodeOuDescarta();
                    }
                    else
                    {
                        escolhida = this.descartaMaiorBode();
                    }
                }
            }

            this.removeCarta(escolhida);
            return escolhida;
        }

        private Carta tentaIlhaOuDescarta()
        {

            Rodada rodada = this.partida.rodadaAtual;
            Carta escolhida;
            Carta menorNaMesa = null;
            Carta maiorNaMesa = null;
            List<Carta> menoresQueNaMesa = new List<Carta>();
            Carta menorNaMao = this.jogador.mao[0];
            bool temCartaMenorNaMesa = false;

            if (rodada.cartasJogadas.Count > 0)
            {
                foreach (Carta c in rodada.cartasJogadas)
                {
                    if (c.id < menorNaMao.id)
                    {
                        temCartaMenorNaMesa = true;
                    }

                    if(menorNaMesa == null || c.id < menorNaMesa.id)
                    {
                        menorNaMesa = c;
                    }

                    if(maiorNaMesa == null || c.id > maiorNaMesa.id)
                    {
                        maiorNaMesa = c;
                    }
                }


                menoresQueNaMesa = this.jogador.mao.Where(c => c.id < menorNaMesa.id).ToList();

                if (!temCartaMenorNaMesa && menoresQueNaMesa.Count > 0)
                {
                    escolhida = menoresQueNaMesa[menoresQueNaMesa.Count - 1];
                }

                escolhida = this.descarta(maiorNaMesa);
            }
            else
            {
                escolhida = this.descarta();
            }

            this.removeCarta(escolhida);
            return escolhida;
        }

        private Carta descarta()
        {
            Carta escolhida = null;
            
            if (this.peso1.Count > 0)
            {
                escolhida = this.peso1[this.peso1.Count - 1];

            }
            else if (this.peso2.Count > 0)
            {
                escolhida = this.peso2[0];
            }

            else if (this.peso3.Count > 0)
            {
                escolhida = this.peso3[this.peso3.Count / 2];
            }

            this.removeCarta(escolhida);
            return escolhida;
        }

        private Carta descarta(Carta maiorNaMesa)
        {
            List<Carta> menoresQueMaiorDaMesa;

            menoresQueMaiorDaMesa = this.jogador.mao.Where(c => c.id < maiorNaMesa.id).ToList();

            if(menoresQueMaiorDaMesa.Count > 0)
            {
                this.removeCarta(menoresQueMaiorDaMesa[menoresQueMaiorDaMesa.Count - 1]);
                return menoresQueMaiorDaMesa[menoresQueMaiorDaMesa.Count - 1];
            }

            return null;
        }

        private Carta tentaBodeOuDescarta()
        {
            Rodada rodada = this.partida.rodadaAtual;
            Carta escolhida;
            Carta maiorNaMesa = null;
            Carta maiorNaMao = this.jogador.mao[this.jogador.mao.Count - 1];
            List<Carta> maioresQueDaMesa;
            
            if (rodada.cartasJogadas.Count > 0)
            {
                foreach (Carta c in rodada.cartasJogadas)
                {
                    if (maiorNaMesa == null || c.id > maiorNaMesa.id)
                    {
                        maiorNaMesa = c;
                    }
                }

                maioresQueDaMesa = this.jogador.mao.Where(c => c.id > maiorNaMesa.id).ToList();

                if (maioresQueDaMesa.Count > 0)
                {
                    escolhida = maioresQueDaMesa[0];
                }
                else
                {
                    escolhida = this.descartaMaiorBode();
                }
            }
            else
            {
                escolhida = this.escolheMaiorCarta();
            }

            this.removeCarta(escolhida);
            return escolhida;
        }

        private Carta descartaMaiorBode()
        {
            Carta escolhida = null;
            List<Carta> cincoBodes = this.jogador.mao.Where(c => c.numBodes == 5).ToList();
            List<Carta> tresBodes = this.jogador.mao.Where(c => c.numBodes == 3).ToList();
            List<Carta> doisBodes = this.jogador.mao.Where(c => c.numBodes == 2).ToList();
            List<Carta> umBode = this.jogador.mao.Where(c => c.numBodes == 1).ToList();

            if(cincoBodes.Count > 0)
            {
                escolhida =  cincoBodes[0];
            } else if(tresBodes.Count > 0)
            {
                escolhida = tresBodes[0];
            }
            else if (doisBodes.Count > 0)
            {
                escolhida = doisBodes[0];
            }
            else if (umBode.Count > 0)
            {
                escolhida = umBode[0];
            }

            this.removeCarta(escolhida);
            return escolhida;
        }

        private bool passouDoLimite()
        {
            double cap = 0.00;
            if (this.partida.tamanhoIlha > 0)
            {
                cap = this.jogador.numBodes / this.partida.tamanhoIlha;
            }
            return (cap * 100) > this.limiteProximidadeIlha;
        }

        public void removeCarta(Carta c)
        {
            if(c != null)
            {
                if (c.id <= 16)
                {
                    foreach (Carta carta in this.peso1)
                    {
                        if (carta.id == c.id)
                        {
                            this.peso1.Remove(carta);
                            return;
                        }
                    }
                }
                else if (c.id <= 34)
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
        }

        public int escolheIlha(int opcao1, int opcao2)
        {
            int maior = opcao1 > opcao2 ? opcao1 : opcao2;
            int menor = opcao1 < opcao2 ? opcao1 : opcao2;

            this.ilhasDefinidas++;

            return !passouDoLimite() ? maior : menor;
        }

        private Carta escolheMaiorCarta()
        {
            Carta escolhida = null;
            if(this.peso3.Count > 0)
            {
                escolhida = this.peso3[0];
            }
            else if(this.peso2.Count > 0)
            {
                escolhida = this.peso2[this.peso2.Count - 1];
            }
            else if (this.peso1.Count > 0)
            {
                escolhida = this.peso1[this.peso1.Count - 1];
            }

            return escolhida;
        }
    }
}
