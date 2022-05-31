﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4.Fiap.Ex2.Models
{
    class Eletronico : Produto
    {
        public bool Garantia { get; set; }

        public Eletronico(int id, string nome) : base(id, nome) { }

        public decimal GarantiaEstendida()
        {
            return Garantia ? Preco * 0.1m : 0;
        }
        
    }
}
