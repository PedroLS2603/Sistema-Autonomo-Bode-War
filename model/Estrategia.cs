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

        public Dictionary<string, double> cenarios;
        public Estrategia(Partida partida, Jogador jogador)
        {
            this.partida = partida;
            this.jogador = jogador;
            this.cenarios = new Dictionary<string, double>();
        }

        public Carta escolherCarta()
        {

            if(this.jogador.mao.Count > 0)
            {
                return this.jogador.mao[0];
            }

            return null;
        }
    }
}
