using System;
using System.Collections.Generic;
using System.Text;

namespace Milhagem.Entities
{
    class Categoria : Pessoa
    {
        public int Status { get; set; }

        public Categoria()
        {

        }
        public Categoria(string id, string nome, string sobrenome, string endereço, string telefoneCelular, string tipoPessoa, int pontos,int status)
            :base(id,nome,sobrenome,endereço,telefoneCelular,tipoPessoa,pontos)
        {
            Status = status;
        }

        public sealed override int AtualizarCadastro()
        {
            int pts = Pontos;
            Pontos = base.AtualizarCadastro() + pts;
            return Pontos;
        }

    }

}
