using System;
using System.Collections.Generic;
using System.Text;

namespace Milhagem.Services
{
    class CotacaoArgentinaService: ICotacao
    {
        //valores de moeda fictício para o exemplo

        private double _cotacaoArgentina = 0.30;

        public double ValorFinal { get; set; }

        public double descontoPassagem(double valorPassagem)
        {
            return ValorFinal = valorPassagem - (valorPassagem * _cotacaoArgentina);

        }

    }
}
