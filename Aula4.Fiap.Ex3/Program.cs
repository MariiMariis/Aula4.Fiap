using Aula4.Fiap.Ex3.Models;
using System;

namespace Aula4.Fiap.Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ler a formação cadastrada
            Console.WriteLine("Digite a formação 1 - Tecnólogo ou 2 - Bacharelado");
            int tipo = int.Parse(Console.ReadLine());

            // Ler dados da formação
            Console.WriteLine("Digite o nome da Instituição:");
            var instituicao = Console.ReadLine();

            // Ler informações sobre o curso escolhido
            Console.WriteLine("Digite o nome da formação:");
            var nome = Console.ReadLine();

            Formacao formacao;
            
            if (tipo == 1)
            {
                Console.WriteLine("Plano estendido?");
                var plano = bool.Parse(Console.ReadLine());


                // Instanciando o objeto
                formacao = new Tecnologo(nome)
                {
                    PlanoEstendido = plano,
                    Instituicao = new Instituicao(instituicao)
                };
            }
            else
            {
                Console.WriteLine("Projeto TCC");
                var projeto = Console.ReadLine();

                Console.WriteLine("Carga horária de estágio");
                var estagio = int.Parse(Console.ReadLine());

                formacao = new Bacharelado(nome, estagio)
                {
                    ProjetoConclusao = projeto,
                    Instituicao = new Instituicao(instituicao)
                };

            }

            //Exibir dados
            Console.WriteLine(formacao);

            // Apresentar um menu com opções
            int op;

            do
            {
                Console.WriteLine("Escolha uma opção: \n1- Calcular média \n2- Calcular Mensalidade \n3- Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        // Ler as 3 notas
                        Console.WriteLine("Digite a nota 1:");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a nota 2:");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a nota 3:");
                        int n3 = int.Parse(Console.ReadLine());
                        // Calcula e exibe as médias
                        Console.WriteLine($"A média é {formacao.CalcularMedia(n1, n2, n3)}");
                        break;
                    case 2:
                        Console.WriteLine($"A mensalidade é {formacao.CalcularMensalidade()}");
                        break;
                    case 3:
                        Console.WriteLine("Finalizando o sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }while(op != 3);
        }  
    }
}

