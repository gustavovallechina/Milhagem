using System;
using System.Collections.Generic;
using System.Text;

namespace Milhagem.Entities
{
    abstract class Pessoa
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Endereco { get; set; }
        public string TelefoneCelular { get; set; }
        public string TipoPessoa { get; set; }
        public int Pontos { get; set; }
        


        public Pessoa()
        {

        }

        public Pessoa(string id, string nome, string sobrenome, string endereco, string telefoneCelular, string tipoPessoa, int pontos)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Endereco = endereco;
            TelefoneCelular = telefoneCelular;
            TipoPessoa = tipoPessoa;
            Pontos = pontos;
            
        }

        public virtual int AtualizarCadastro()
        {
            return Pontos += 10;
        }

        public override string ToString()
        {
            return $"Dados do cliente: Nome: {Nome} Sobrenome: {Sobrenome} Celular: {TelefoneCelular} Pontos: {Pontos}";
        }


    }
}
