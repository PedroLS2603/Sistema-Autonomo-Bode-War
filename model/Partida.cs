using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piBodeWar.model
{
    public class Partida
    {
        public string id {get; private set;}
        public string nome {get; private set;}
        public string senha { get; private set;}
        public List<Jogador> jogadores { get; private set;}
        public Jogador vencedor { get; set;}

        public Partida(string id, string nome, string senha)
        {
            this.id = id;
            this.nome = nome;
            this.senha = senha;
            this.jogadores = new List<Jogador>();
        }
    }
}
