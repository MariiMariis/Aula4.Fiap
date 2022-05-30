using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4.Fiap.Models
{
    class Moto : Veiculo
    {

        public bool PartidaEletrica { get; set; }


        // Contrutor que invoca o construtor de veículo, contendo 3 parâmetros
        public Moto(string cor, string motor, int ano, bool partida) 
                                                    : base(cor, motor, ano)
        {
            PartidaEletrica = partida;
        }

        public Moto() { }


        // Sobrescreve o método Acelerar da classe pai
        public override void Acelerar()
        {
            Console.WriteLine($"Moto acelerando...");
        }

        public override string ToString()
        {
            return base.ToString() + $" \nPartida elétrica: {(PartidaEletrica ? "Sim" : "Não")}";
        }

    }
}
