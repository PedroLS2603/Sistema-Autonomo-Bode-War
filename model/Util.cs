using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace piBodeWar.model
{
    public static class Util
    {

        public static string betweenString(string origem, string strInicio, string strFim)
        {
            int inicio, fim;
            inicio = origem.IndexOf(strInicio, 0) + strInicio.Length;
            fim = origem.IndexOf(strFim, inicio);
            string temp = origem.Substring(inicio, fim - inicio);
            return inicio < 0 || fim < 0 || inicio > origem.Length || fim > origem.Length ? null : origem.Substring(inicio, fim - inicio);
        }

        public static string substring(string origem, string strInicio, string strFim)
        {
            int inicio, fim;
            inicio = origem.IndexOf(strInicio, 0);
            fim = origem.IndexOf(strFim, inicio);
            string temp = origem.Substring(inicio, fim);
            return inicio < 0 || fim < 0 || inicio > origem.Length || fim > origem.Length ? null : origem.Substring(inicio, fim - inicio);
        }
        public static string removeSubstring(string origem, string strInicio, string strFim)
        {
            string substring = Util.substring(origem, strInicio, strFim);
            substring += " bodes";
            return origem.Replace(substring, "");
        }

        public static int obterQtdDeBodesPorNarracao(string narracao, string nomeJogador)
        {
            int qtdBodes = 0;
            narracao = narracao.Replace('\r'.ToString(), "");

            string[] arrNarracao = narracao.Split('\n');

            for(int i = 0; i < arrNarracao.Length; i++)
            {
                string linhaNarracao = arrNarracao[i];
                int frequenciaQueRecebeuBodes = Regex.Matches(linhaNarracao, $"{nomeJogador} recebeu").Count;

                if (frequenciaQueRecebeuBodes > 0)
                {
                    string strQtdBodes = Util.betweenString(linhaNarracao, $"{nomeJogador} recebeu ", " bodes");
                    qtdBodes += Int32.Parse(strQtdBodes);
                }
            }

            return qtdBodes;
        }
    }
}
