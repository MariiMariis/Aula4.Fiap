using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4.Fiap.Models
{
    class Veiculo
    {
        //Propriedades da classe

        //Uma propriedade é um membro que oferece um mecanismo flexível para ler,
        //gravar ou calcular o valor de um campo particular. As propriedades podem
        //ser usadas como se fossem membros de dados públicos, mas na verdade elas
        //são métodos realmente especiais chamados acessadores. Isso permite que os
        //dados sejam acessados facilmente e ainda ajuda a promover a segurança e a
        //flexibilidade dos métodos.


        //Um acessador de propriedade get é usado para retornar o valor da propriedade
        //e um acessador de propriedade set é usado para atribuir um novo valor. 
        public string Cor { get; set; }

        public string Motor { get; set; }

        public int Ano { get; set; }

        // Herda as propriedade da classe Fabricante
        public Fabricante Fabricante { get; set; }


        //Construtores pode sem facilmente estruturados à partir do atalho 'ctor' + tab +tab
        //Possuem os memso nome da classe a qual pertencem

        // O construtor abaixo implementa as propriedades de Cor, Motor e Ano

        public Veiculo(string cor, string motor, int ano)
        {
            Cor = cor;
            Motor = motor;
            Ano = ano;
      
        }

        //Construtor padrão
        public Veiculo() { }


        // Virtual - Permite sobrescrição pelas classes filhas
        // void - método sem return
        public virtual void Acelerar()
        {
            Console.WriteLine("Veiculo acelerando...");
        }

        // Método que recebe um parêmetro de aceleração
        public void Acelerar(double aceleracao)
        {
            Console.WriteLine($"Veículo acelerando a {aceleracao} km/h");
        }

        // Método que recebe um booleano e um valor de ponto flutuante
        public double Acelerar(bool turbo, double velocidade)
        {
            var velocidadeFinal = turbo ? velocidade * 10 : velocidade;
            Console.WriteLine($"Veículo acelerando a  {velocidadeFinal}, possui turbo: {turbo}");
            return velocidadeFinal;
        }

        public virtual void Frear(double velocidadeAtual, bool parado, double velocidadeFrenagem)
        {
            var velocidadeFinal = !parado ? velocidadeAtual - velocidadeFrenagem : 0;
            Console.WriteLine($"Velocidade atual: {velocidadeFinal}");
        }


        //Sobrescrever o método para que exiba todos os dados do veículo
        public override string ToString()
        {
            return $"Cor: {Cor} \nMotor: {Motor} \nAno: {Ano} \n {Fabricante}";
        }

    }
}
