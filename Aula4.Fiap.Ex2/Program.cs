using Aula4.Fiap.Ex2.Models;
using System;

namespace Aula4.Fiap.Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciando produto passando informações
            Produto sapato = new Produto(1, "Sapato social masculino")
            {
                Preco = 4000
            };


            // Instanciando eletronico passando informações
            Eletronico laptop = new Eletronico(1, "Macbook Pro")
            {
                Preco = 4000,
                Garantia = true
            };

            DateTime data = new DateTime(2021, 11, 15); // Ano, mês e dia
            DateTime dataHoje =  DateTime.Now; //Retornando data atual

            // Instanciando novo perecível
            Perecivel macarrao = new Perecivel(2, "Macarrão parafuso", dataHoje);

            //Exibindo a data
            Console.WriteLine($"Data de validade: {macarrao.DataValidade}");
            Console.WriteLine($"Data de validade só com o dia: {macarrao.DataValidade.ToShortDateString()}");
            Console.WriteLine($"Mes: {macarrao.DataValidade.Month} Ano: {macarrao.DataValidade.Year}");

            // Calcula desconto
            var desconto = sapato.CalcularDesconto(15);
            Console.WriteLine($"Valor do produto: {sapato.Preco}\nValor do produto com desconto: {desconto}");


            //Calcula garantia estendida para eletrônicos
            Console.WriteLine($"Valor da garantia estendida {laptop.GarantiaEstendida()}");


        }
    }
}
