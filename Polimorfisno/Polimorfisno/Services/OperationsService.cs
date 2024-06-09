using System;
using Milhagem.Entities;
namespace Milhagem.Services
{
    class OperationsService :IOperationsService
    {
        public bool clienteVip(int pontos)
        {

            if (pontos >= 5000)
            {
                return true;
            }
            else if (pontos == 0)
            {
                throw new MilhagemException("Saldo de pontos não pode ser 0.");

            }

            else if (pontos < 0)
            {
                throw new MilhagemException("Saldo de pontos não pode ser negativo.");

            }
            else
            {
                return false;
            }

        }

        public bool tamanhoCpf(string cpf)
        {
            if (cpf.Length == 11)
            {
                return true;
            }
            return false;
        }

        public bool Funcionario(char func)
        {
            if (func == 'S')
            {
                return true;
            }
            return false;
        }

    }
}
