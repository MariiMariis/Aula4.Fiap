using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4.Fiap.Ex2.Models
{
    class Perecivel : Produto
    {
        public DateTime DataValidade { get; set; }

        public Perecivel(int id, string nome, DateTime dataValidade) : base(id, nome)
        {
            DataValidade = dataValidade;
        }
    }
}
