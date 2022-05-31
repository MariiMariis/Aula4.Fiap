using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4.Fiap.Ex3.Models
{
    class Instituicao
    {
        public string Nome { get; set; }

        public Instituicao(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return $"Instituição: {Nome}";
        }
    }
}
