﻿using BodeOfWarServer;
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
        public int numBodes { get; private set; }
        public bool isBot { get; set; }
        public List<Carta> mao { get; }

        public System.Drawing.Color cor;
        public Jogador(string id, string nome, int cor)
        {
            this.id = id;
            this.nome = nome;
            switch(cor)
            {
                case 1:
                    this.cor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Yellow);
                    break;
                case 2:
                    this.cor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Blue);
                    break;
                case 3:
                    this.cor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Green);
                    break;
                case 4:
                    this.cor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Red);
                    break;
            }
        }
        public Jogador(string id, string nome, string senha, bool isBot)
        {
            this.id = id;
            this.nome = nome;
            this.senha = senha;
            this.mao = new List<Carta>();
            this.numBodes = 0;
            this.isBot = isBot;
            this.cor = System.Drawing.Color.Yellow;
        }

        public void jogarCarta()
        {
            Carta escolhida = this.escolherCarta();

            Jogo.Jogar(Int32.Parse(this.id), this.senha, escolhida.id);

            this.mao.Remove(escolhida);

        }

        public Carta escolherCarta()
        {

            return mao[0];
        }

        public Jogador verificaVez(Partida partida)
        {
            string retorno = Jogo.VerificarVez(Int32.Parse(partida.id));
            retorno = retorno.Replace('\r'.ToString(), "");
            retorno = retorno.Replace('\n'.ToString(), "");

            Jogador quemJoga;

            if (retorno.StartsWith("ERRO"))
            {
                quemJoga = null;
            }
            else {
                string[] arrRetorno = retorno.Split(',');
                string statusPartida = arrRetorno[0];
                string idJogador = arrRetorno[1];
                string idRodada = arrRetorno[2];
                if(idRodada == "1")
                {
                    partida.listarJogadores();
                }
                char statusRodada = arrRetorno[3][0];
                partida.status = statusPartida[0];
                if (statusRodada == 'B' && idRodada != partida.rodadaAtual.id)
                {
                    partida.rodadaAtual.distribuirPremios();
                    partida.setRodadaAtual(new Rodada(idRodada, statusRodada, 0, partida));
                }
                else if(statusRodada == 'I' && idRodada == partida.rodadaAtual.id)
                {
                    partida.rodadaAtual.setStatus(statusRodada);
                }

                quemJoga = partida.buscarJogador(idJogador);
            }


            return quemJoga;
        }

        public List<Carta> verMao(Partida partida)
        {
            string strCartas = Jogo.VerificarMao(Int32.Parse(this.id), this.senha);

            if (!(strCartas.StartsWith("ERRO")))
                this.mao.Clear();
                   
                strCartas.Replace('\r'.ToString(), String.Empty);
                string[] arrCartas = strCartas.Split('\n');

                foreach (string c in arrCartas)
                {

                    if (c != "")
                    {
                        int num = Int32.Parse(c);

                        Carta carta = partida.buscarCarta(num);
                        carta.setDono(this);
                        this.mao.Add(carta);
                    }
                    else { break; }

                }
            return this.mao;
        }

        public void escolherIlha() {
            string retorno = Jogo.VerificarIlha(Int32.Parse(this.id), this.senha);
            string[] opcoesIlha = retorno.Split(',');

            Jogo.DefinirIlha(Int32.Parse(this.id), this.senha, Int32.Parse(opcoesIlha[0]));
        }

        public void verificarMesa(Partida partida)
        {
            partida.rodadaAtual.cartasJogadas.Clear();
            string status;

            status = Jogo.VerificarMesa(Int32.Parse(partida.id));


            status = status.Replace('\r'.ToString(), String.Empty);
            string[] arrStatus = status.Split('\n');

            foreach (string jogada in arrStatus)
            {
                if(jogada.StartsWith("I"))
                {
                    string tamanhoIlha = jogada.Replace("I", "");
                    partida.setTamanhoIlha(Int32.Parse(tamanhoIlha));
                }
                else if(jogada != "")
                {
                    string[] arrJogada = jogada.Split(',');
                    string idJogador = arrJogada[0];
                    string idCarta = arrJogada[1];
                    Carta carta = partida.buscarCarta(Int32.Parse(idCarta));

                    carta.setDono(partida.buscarJogador(idJogador));
                    partida.rodadaAtual.cartasJogadas.Add(carta);
                    partida.rodadaAtual.adicionarBodes(carta.numBodes);
                }
            }
        }
        public void iniciarPartida(Partida partida)
        {
            partida.listarJogadores();
            string retorno = Jogo.IniciarPartida(Int32.Parse(this.id), this.senha);

            if(!(retorno.StartsWith("ERRO")))
            {
                partida.setRodadaAtual(new Rodada("1", 'B', 0, partida));
                partida.status = 'J';
                this.verMao(partida);
            }
            
        }

        public void adicionarBodes(int valor)
        {
            if(valor > 0)
            {
                this.numBodes += valor;
            }
        }

        public void entrarNaPartida(Partida partida)
        {
            Jogo.EntrarPartida(Int32.Parse(partida.id), this.nome, this.senha);
        }

        public void encerrarPartida(Partida partida)
        {
            partida.encerrar();
        }
    }
}
