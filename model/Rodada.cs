using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piBodeWar.model
{
    public class Rodada
    {
        public List<Carta> cartasJogadas { get; private set; }

        public Jogador vencedor { get; set; }

        public Jogador perdedor { get; set; }

        public int totalBodes { get; private set; }

        public Rodada()
        {
            this.cartasJogadas = new List<Carta>();
        }

        public void adicionarBodes(int valor)
        {
            this.totalBodes += valor;
        }
    }
}
