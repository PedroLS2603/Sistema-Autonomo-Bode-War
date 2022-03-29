using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piBodeWar.model
{
    public class Carta
    {
        public int id { get; }
        public int numBodes { get; }
        public string imagem { get; }

        public Carta(int id, int numBodes, int arte)
        {
            this.id = id;
            this.numBodes = numBodes;
            switch (arte)
            {
                case 1:
                    this.imagem = "../assets/b1.png";
                    break;
                case 2:
                    this.imagem = "../assets/b2.png";
                    break;
                case 3:
                    this.imagem = "../assets/b3.png";
                    break;
                case 4:
                    this.imagem = "../assets/b4.png";
                    break;
                case 5:
                    this.imagem = "../assets/b5.png";
                    break;
                case 6:
                    this.imagem = "../assets/b6.png";
                    break;
                case 7:
                    this.imagem = "../assets/b7.png";
                    break;
                case 8:
                    this.imagem = "../assets/b8.png";
                    break;
                case 9:
                    this.imagem = "../assets/b9.png";
                    break;
                case 10:
                    this.imagem = "../assets/b10.png";
                    break;
            }
        }
    }
}
