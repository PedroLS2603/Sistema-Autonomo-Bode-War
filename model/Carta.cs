using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piBodeWar.model
{
    public class Carta
    {
        public int id { get; }
        public int numBodes { get; }
        public Image imagem { get; }

        public Jogador detentor { get; private set; }

        public Carta(int id, int numBodes, int arte)
        {
            this.id = id;
            this.numBodes = numBodes;
            switch (arte)
            {
                case 1:
                    this.imagem = Properties.Resources.b1;
                    break;
                case 2:
                    this.imagem = Properties.Resources.b2;
                    break;
                case 3:
                    this.imagem = Properties.Resources.b3;
                    break;
                case 4:
                    this.imagem = Properties.Resources.b4;
                    break;
                case 5:
                    this.imagem = Properties.Resources.b5;
                    break;
                case 6:
                    this.imagem = Properties.Resources.b6;
                    break;
                case 7:
                    this.imagem = Properties.Resources.b7;
                    break;
                case 8:
                    this.imagem = Properties.Resources.b8;
                    break;
                case 9:
                    this.imagem = Properties.Resources.b9;
                    break;
                case 10:
                    this.imagem = Properties.Resources.b10;
                    break;
            }
   
        }
        public void setDono(Jogador dono)
        {
            if(dono != null)
            {
                this.detentor = dono;
            }
        }
    }
}
