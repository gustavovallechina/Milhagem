using System;
using System.Collections.Generic;
using System.Text;

namespace Milhagem.Services
{
    interface ICotacao
    {
        public double ValorFinal { get; set; }
        double descontoPassagem(double valorPassagem);
    }
}
