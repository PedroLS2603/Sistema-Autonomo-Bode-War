﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piBodeWar.model
{
    public static class Util
    {

        public static string substring(string origem, string strInicio, string strFim)
        {
            int inicio, fim;
            inicio = origem.IndexOf(strInicio, 0) + strInicio.Length;
            fim = origem.IndexOf(strFim, inicio);
            return origem.Substring(inicio, fim - inicio);
        }
    }
}
