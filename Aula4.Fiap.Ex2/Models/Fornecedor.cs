using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4.Fiap.Ex2.Models
{
    class Fornecedor
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public Fornecedor(int id, string nome, string telefone)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
        }
    }
}
