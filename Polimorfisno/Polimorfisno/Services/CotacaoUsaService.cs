using System;
using System.Collections.Generic;
using System.Text;

namespace Milhagem.Services
{
    class CotacaoUsaService: ICotacao
    {
        //valores de moeda fictício para o exemplo

        private double _cotacaoUsa = 0.50;

        public double ValorFinal { get; set; }

        public double descontoPassagem(double valorPassagem)
        {
            return ValorFinal = valorPassagem - (valorPassagem * _cotacaoUsa);

        }

    }
}
