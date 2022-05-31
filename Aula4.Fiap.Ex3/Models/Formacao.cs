using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4.Fiap.Ex3.Models
{
    // Classe abstrata -> não pode ser isntanciada e pode conter métodos abstratos.
    abstract class Formacao
    {
        //Propriedades da classe
        public string Nome { get; set; }

        public int Duracao { get; set; }

        public decimal Mensalidade { get; set; }

        public Instituicao Instituicao { get; set; }

        public Formacao(string nome)
        {
            Nome = nome;
            DefinirDuracao();

        }

        public abstract void DefinirDuracao();


        //Overload de métodos
        public float CalcularMedia(float nota1, float nota2)
        {
            return (nota1 + nota2) / 2;
        }

        public float CalcularMedia(float nota1, float nota2, float nota3)
        {
            if(nota1 < nota2 && nota1 < nota3)
            {
                return CalcularMedia(nota2, nota3);
            }
            else if (nota2 < nota1 && nota2 < nota3)
            {
                return CalcularMedia(nota1, nota3);
            }
            return CalcularMedia(nota1, nota2);
        }


        // Metodo para calcular a média

        public virtual decimal CalcularMensalidade()
        {
            return Mensalidade = Duracao * 400;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} \nDuração: {Duracao} \nMesalidade: {Mensalidade} \n{Instituicao}";
        }





    }
}
