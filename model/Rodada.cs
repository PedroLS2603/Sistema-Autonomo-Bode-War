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

        public Rodada(string id, char status, int totalBodes, Partida partida)
        {
            this.id = id;
            this.status = status;
            this.totalBodes = totalBodes;
            this.cartasJogadas = new List<Carta>();
            this.partida = partida;
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
            if(this.vencedor != null)
            {
                this.vencedor = null;
            }
            foreach(Carta carta in this.cartasJogadas)
            {
                if(carta.id > maiorNum)
                {
                    vencedora = carta;
                }
            }
            if(vencedora != null)
            {
                this.vencedor = vencedora.detentor;
            }

            return this.vencedor;
        } 
    }
}
