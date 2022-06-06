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

        public char status { get; private set; }
        public List<Carta> cartasJogadas { get; }

        public Jogador vencedor { get; set; }

        public Jogador perdedor { get; set; }

        public Partida partida { get; }
        
        public int totalBodes { get; private set; }

        public bool distribuiuPremio { get; set; }

        public Rodada(string id, char status, int totalBodes, Partida partida)
        {
            this.id = id;
            this.status = status;
            this.totalBodes = totalBodes;
            this.cartasJogadas = new List<Carta>();
            this.partida = partida;
            this.distribuiuPremio = false;
        }

        public void adicionarBodes(int valor)
        {
            if(valor > 0)
            {
                this.totalBodes += valor;
            }
        }

        public void distribuirPremios()
        {
            this.distribuiuPremio = true;
            this.verificaPerdedor();
            this.verificaVencedor();
            if(this.vencedor != null)
            {
                this.vencedor = this.partida.buscarJogador(this.vencedor.id);
                this.vencedor.adicionarBodes(this.totalBodes);
            }
        }

        public void setStatus(char status)
        {
            if(status == 'B' || status == 'I' || status == 'E')
            {
                this.status = status;
            }
        }

        private Jogador verificaVencedor()
        {
            int maiorNum = 0;
            Carta vencedora = null;
            foreach(Carta carta in this.cartasJogadas)
            {
                if(carta.id > maiorNum)
                {
                    maiorNum = carta.id;
                    vencedora = carta;
                }
            }
            if(vencedora != null)
            {
                this.vencedor = vencedora.detentor;
            }

            return this.vencedor;
        }

        private Jogador verificaPerdedor()
        {
            int menor = 0;
            Carta perdedora = null;

            for(int i = 0; i < this.cartasJogadas.Count; i++)
            {
                Carta carta = this.cartasJogadas[i];
                if(carta.id < menor || i == 0)
                {
                    menor = carta.id;
                    perdedora = carta;
                }
            }

            if(perdedora != null)
            {
                this.perdedor = perdedora.detentor;
            }

            return this.perdedor;
        }
    }
}
