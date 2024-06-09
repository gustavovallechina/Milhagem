using System;
using System.Collections.Generic;
using System.Text;

namespace Milhagem.Entities
{
    class PessoaJuridica : Pessoa
    {
        public string cnpj { get; private set; }
       

        public PessoaJuridica()
        {

        }

        public PessoaJuridica(string cnpj, string id, string nome, string sobrenome, string endereco, string telefoneCelular, string tipo, int pontos)
        : base(id, nome, sobrenome, endereco, telefoneCelular, tipo, pontos)
        {
            this.cnpj = cnpj;
            
        }
    }

    
}
