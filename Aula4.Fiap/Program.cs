using Aula4.Fiap.Models;
using System;

namespace Aula4.Fiap
{
    // Crie um serviço para lojas de veículos, que retorne informações sobre
    // os diversos veículos cadastrados, seus atributos e os retorne no console.

    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando fabricante
            // Nome da classe + nome do objeto a ser criado = new Nome da classe()
            Fabricante honda = new Fabricante() {Nome = "Honda"};


            // Instanciando um carro
            // Nome da classe + nome do objeto a ser criado = new Nome da classe()
            Carro carro = new Carro();

            carro.Motor = "2.0 Turbo";
            carro.Cor = "Preto";
            carro.Ano = 2021;
            carro.ArCondicionado = true;
            carro.QuantidadePortas = 4;
            carro.Fabricante = honda;

            //Instanciando uma moto
            // Nome da classe + nome do objeto a ser criado = new Nome da classe()
            Moto cg = new Moto()
            {
                PartidaEletrica = true,
                Ano = 2022,
                Cor = "Prata",
                Motor = "120",
                Fabricante = honda
            };

            //Instanciando um veículo
            Veiculo veiculo = new Veiculo();

            veiculo.Ano = 2015;
            veiculo.Motor = "70HP";
            veiculo.Cor = "Vermelho";

            // Instanciando outro veículo à partir do construtor na classe veículo
            Veiculo veiculo2 = new Veiculo("Amarelo", "100c", 2022);

            // Carro carro3 = new Carro("Rosa", "1.6", 2000);  <- Construtor não é herdado

            //Versões herdadas do método acelerar
            carro.Acelerar();
            cg.Acelerar();
            veiculo.Acelerar();

            //Outras versões do método acelerar
            carro.Acelerar(20);
            carro.Acelerar(true, 20);

            //Instanciando carros e motos com utilização de construtores com parâmetros diferentes
            Veiculo v1 = new Carro("Branco", "1.0", 2007, true, 4); // Carro é um veículo
            Veiculo v2 = new Carro(3); // Carro é um veículo
            Veiculo v3 = new Carro(); // Carro é um veículo

            //Carro cr = new Veiculo();   <- Não compila, pois um veículo não é necessariamente um carro
            //Moto mt = new Veiculo();   <- Não compila, pois um veículo não é necessariamente uma moto


            Veiculo v4 = new Moto(); // Moto é um veículo
            Veiculo v5 = new Moto("Preto", "300c", 2020, true); // Moto é um veículo

            // chamando o método acelerar do veículo e da moto
            v1.Acelerar(); // Veículo
            v4.Acelerar(); // Moto

            //Chamando método frear do veículo e do carro
            veiculo.Frear(100, false, 10); // veículo
            carro.Frear(100, false, 10); //Carro

            Console.WriteLine("------------------------");
            Console.WriteLine($"Carro: {carro}");

            Console.WriteLine("------------------------");
            Console.WriteLine($"Moto: {cg}");

            Console.WriteLine("------------------------");
            Console.WriteLine($"Veículo: {veiculo}");

        }
    }
}
