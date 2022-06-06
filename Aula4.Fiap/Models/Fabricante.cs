using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4.Fiap.Models
{
    //Criando classe fabricante, que será herdada por outras classes.
    class Fabricante
    {
        // Criando Field (Atributo ou propriedade) Nome
        public string Nome { get; set; }


        // Método que retorna o nome do fabricante
        public override string ToString()
        {
            return $"Fabricante: {Nome}";
        }

    
    }
}
