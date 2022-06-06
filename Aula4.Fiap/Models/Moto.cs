using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4.Fiap.Models
{
    // Moto herda de Veículo. O simbolo ':' indica essa relação. (herda de)
    class Moto : Veiculo
    {
        //Propriedade da classe moto
        public bool PartidaEletrica { get; set; }


        // Contrutor que invoca o construtor de veículo, contendo 3 parâmetros
        // o Simbolo ':', indica a herança da classe base para este construtor
        public Moto(string cor, string motor, int ano, bool partida) 
                                                    : base(cor, motor, ano)
        {
            PartidaEletrica = partida;
        }

        // Invoca o construtor padrão da classe moto
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
