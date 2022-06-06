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

        public Estrategia(Partida partida, Jogador jogador)
        {
            this.peso1 = new List<Carta>(); 
            this.peso2 = new List<Carta>(); 
            this.peso3 = new List<Carta>(); 
            this.limiteProximidadeIlha = 70.0;
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
            Carta maiorNaMesa = null;
            Rodada rodada = this.partida.rodadaAtual;
            Carta escolhida = null;

            foreach (Carta c in rodada.cartasJogadas)
            {
                if (maiorNaMesa == null || c.id > maiorNaMesa.id)
                {
                    maiorNaMesa = c;
                }
            }

            if (this.jogador.mao.Count > 0)
            {
                if (Int32.Parse(rodada.id) <= 4)
                {
                    if(this.ilhasDefinidas <= 2)
                    {
                        escolhida = this.tentaIlhaOuDescarta();
                    }
                    else {
                        if(maiorNaMesa != null)
                        {
                            escolhida = this.descartaMaiorBode(maiorNaMesa);
                        }
                        else { 
                            escolhida = this.descarta();
                        }
                    }
                }
                else
                {
                    if (!this.passouDoLimite(this.jogador))
                    {
                        escolhida = this.tentaBodeOuDescarta();
                    }
                    else
                    {
                        escolhida = this.descartaMaiorBode(maiorNaMesa);
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
                if(menorNaMao.id <= 5)
                {
                    escolhida = menorNaMao;
                }
                else
                {
                    escolhida = this.descarta();
                }
            }

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

            return escolhida;
        }

        private Carta descarta(Carta maiorNaMesa)
        {
            List<Carta> menoresQueMaiorDaMesa;
            List<Carta> maioresQueMaiorDaMesa;

            menoresQueMaiorDaMesa = this.jogador.mao.Where(c => c.id < maiorNaMesa.id).ToList();
            maioresQueMaiorDaMesa = this.jogador.mao.Where(c => c.id > maiorNaMesa.id).ToList();


            if (menoresQueMaiorDaMesa.Count > 0)
            {
                this.removeCarta(menoresQueMaiorDaMesa[menoresQueMaiorDaMesa.Count - 1]);
                return menoresQueMaiorDaMesa[menoresQueMaiorDaMesa.Count - 1];
            }
            else
            {
                this.removeCarta(maioresQueMaiorDaMesa[maioresQueMaiorDaMesa.Count / 2]);
                return maioresQueMaiorDaMesa[maioresQueMaiorDaMesa.Count / 2];
            }
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
                    escolhida = this.descartaMaiorBode(maiorNaMesa);
                }
            }
            else
            {
                escolhida = this.escolheMaiorCarta();
            }

            return escolhida;
        }

        private Carta descartaMaiorBode(Carta maiorNaMesa)
        {
            Carta escolhida = null;
            Carta maiorNaMao = this.jogador.mao[this.jogador.mao.Count - 1];
            List<Carta> cincoBodes;
            List<Carta> tresBodes;
            List<Carta> doisBodes;
            List<Carta> umBode;
            if (maiorNaMesa != null && maiorNaMao.id < maiorNaMesa.id)
            {
                cincoBodes = this.jogador.mao.Where(c => c.numBodes == 5 && c.id < maiorNaMesa.id).ToList();
                tresBodes = this.jogador.mao.Where(c => c.numBodes == 3 && c.id < maiorNaMesa.id).ToList();
                doisBodes = this.jogador.mao.Where(c => c.numBodes == 2 && c.id < maiorNaMesa.id).ToList();
                umBode = this.jogador.mao.Where(c => c.numBodes == 1 && c.id < maiorNaMesa.id).ToList();
            }
            
            else
            {
                cincoBodes = this.jogador.mao.Where(c => c.numBodes == 5).ToList();
                tresBodes = this.jogador.mao.Where(c => c.numBodes == 3).ToList();
                doisBodes = this.jogador.mao.Where(c => c.numBodes == 2).ToList();
                umBode = this.jogador.mao.Where(c => c.numBodes == 1).ToList();
            }
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

            return escolhida;
        }

        private bool passouDoLimite(Jogador jogador)
        {
            jogador = this.partida.buscarJogador(jogador.id);
            Double cap = 0.00;
            if (this.partida.tamanhoIlha > 0)
            {
                cap = (double)jogador.numBodes / (double)this.partida.tamanhoIlha;
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
            int idRodada = Int32.Parse(this.partida.rodadaAtual.id);
            int maior = opcao1 > opcao2 ? opcao1 : opcao2;
            int menor = opcao1 < opcao2 ? opcao1 : opcao2;

            this.ilhasDefinidas++;

            return passouDoLimite(this.jogador) && idRodada > 2 ? maior : menor;
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
