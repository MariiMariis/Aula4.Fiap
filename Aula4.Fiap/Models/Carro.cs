using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4.Fiap.Models
{
    // Carro herda de Veículo. O simbolo ':' indica essa relação (herda de)
    class Carro : Veiculo
    {

        // Propriedades da classe carro
        public bool ArCondicionado { get; set; }

        public int QuantidadePortas { get; set; }


        //Construtor invocando o construtor pai com 3 parâmetros
        public Carro(string cor, string motor, int ano, bool ar, int portas) 
                                                                : base(cor, motor, ano)
        {
            ArCondicionado = ar;
            QuantidadePortas = portas;
        }


        // Invoca o construtor padrão da classe carro
        public Carro() { }

        // construtor que recebe apenas a propriedade quantidade de portas
        public Carro(int quantidade)
        {
            QuantidadePortas= quantidade;
        }


        // Sobrescrevendo o método Pai, permitindo que o carro pare 80% mais devagar
        // A palavra override sobrescreve o comportamento do método herdado da classe 'Pai' (Veículo)
        public override void Frear(double velocidadeAtual, bool parado, double velocidadeFrenagem)
        {
            // Adiciona comportamento ao método pai
            var velocidadeFrenagemCarro = velocidadeFrenagem * 0.8;
            Console.WriteLine($"Nova velocidade de frenagem {velocidadeFrenagemCarro}");
            
            // Chama o método pai
            base.Frear(velocidadeAtual, parado, velocidadeFrenagem);
        }

        public override string ToString()
        {
            return base.ToString()
                + $" \nAr-condicionado: {(ArCondicionado? "Tem" : "Não tem")} \nNumero de Portas: {QuantidadePortas}";
        }




    }
}
