using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4.Fiap.Models
{
    class Fabricante
    {

        public string Nome { get; set; }

        public override string ToString()
        {
            return $"Fabricante: {Nome}";
        }
    }
}
