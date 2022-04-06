using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piBodeWar.model
{
    public class Jogador
    {
        public string id { get; }
        public string nome { get; }
        public string senha { get; }
        public List<Rodada> rodadasGanhas { get; }
        public int numBodes { get; }
        public List<Carta> mao { get; }

        public Jogador(string id, string nome, string senha) { 
            this.id = id;
            this.nome = nome;
            this.senha = senha;
            this.rodadasGanhas = new List<Rodada>();
            this.mao = new List<Carta>();
            this.numBodes = 0;
        }

        public Carta jogar()
        {
            return mao[0];
        }

    }
}
