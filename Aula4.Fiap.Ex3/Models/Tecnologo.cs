using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4.Fiap.Ex3.Models
{
    class Tecnologo : Formacao
    {
        public bool PlanoEstendido { get; set; }

        public Tecnologo(string nome) : base(nome) { }

        public override decimal CalcularMensalidade()
        {
            return Mensalidade = Duracao * 500;
        }

        public override void DefinirDuracao()
        {
            Duracao = 24;
        }

        public override string ToString()
        {
            return base.ToString() + $" Plano estendido: {PlanoEstendido}" ;
        }
    }
}
