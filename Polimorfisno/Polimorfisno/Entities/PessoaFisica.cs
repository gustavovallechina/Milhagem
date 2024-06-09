using System;
using System.Collections.Generic;
using System.Text;

namespace Milhagem.Entities
{
    class   PessoaFisica : Pessoa
    {
        public string cpf { get;  private set; }
        

        public PessoaFisica()
        {

        }

        public PessoaFisica(string cpf, string id, string nome, string sobrenome, string endereco, string telefoneCelular, string tipo, int pontos)
        : base(id,nome,sobrenome,endereco,telefoneCelular,tipo,pontos)
        {
            this.cpf = cpf;
            
        }

       


        //métodos
        
        public void exemploSobrecargaMetodo(string nome)
        {
            Console.WriteLine(nome);
        }

        public void exemploSobrecargaMetodo(int idade)
        {
            Console.WriteLine(idade);
        }


    }
}



