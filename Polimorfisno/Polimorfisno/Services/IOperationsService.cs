using System;
using System.Collections.Generic;
using System.Text;

namespace Milhagem.Services
{
    interface IOperationsService
    {
        bool clienteVip(int pontos);
        bool tamanhoCpf(string cpf);
        bool Funcionario(char func);
       

    }
}
