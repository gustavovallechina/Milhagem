using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Milhagem.Services
{
    class CotacaoRealService : ICotacao
    {
        //valores de moeda fictício para o exemplo

        private double _cotacaoReal = 0.25;

        public double ValorFinal { get; set; }

        public double descontoPassagem(double valorPassagem)
        {
            return ValorFinal = valorPassagem - (valorPassagem * _cotacaoReal);

        }

        
    }
}
