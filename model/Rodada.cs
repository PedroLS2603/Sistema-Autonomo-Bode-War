using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piBodeWar.model
{
    public class Rodada
    {
        public string id { get; }

        public char status { get; set; }
        public List<Carta> cartasJogadas { get; }

        public Jogador vencedor { get; set; }

        public Jogador perdedor { get; set; }

        public int totalBodes { get; private set; }

        public Rodada(string id, char status, int totalBodes)
        {
            this.id = id;
            this.status = status;
            this.totalBodes = totalBodes;
            this.cartasJogadas = new List<Carta>();
        }

        public void adicionarBodes(int valor)
        {
            this.totalBodes += valor;
        }

        public void distribuirPremios()
        {
            this.vencedor.adicionarBodes(this.totalBodes);
        }
    }
}
