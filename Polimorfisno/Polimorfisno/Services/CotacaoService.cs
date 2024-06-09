using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace Milhagem.Services
{
    class CotacaoService 
    {
        private ICotacao _icotacao;

        public CotacaoService(ICotacao icotacao)
        {
            _icotacao = icotacao;
        }


        public void tipoMoeda(double valorPassagem)
        {
            _icotacao.descontoPassagem(valorPassagem);
            

        }

        public override string ToString()
        {
            return "Valor a pagar com desconto de acordo com a cotação da moeda: "
            + _icotacao.ValorFinal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
