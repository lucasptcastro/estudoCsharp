using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudoCsharp
{
    public class Aluno
    {

        // Atributos
        public string nome;

        public double nota1, nota2;

        // Média
        public double Media()
        {
            return (nota1 + nota2) / 2;
        }

        // Situação
        public string Situacao(double media)
        { 
            if (media >= 7)
            {
                return "Aprovado!";
            }
            else
            {
                return "Reprovado!";
            }
        }

        // Mensagem
        public void Mensagem()
        {
            double pegarMedia = Media();
            string situacao = Situacao(pegarMedia);

            if (situacao == "Aprovado!")
            {
                Console.WriteLine($"{nome}, sua média foi igual a {pegarMedia}! Aprovado!");
            }
            else 
            {
                Console.WriteLine($"{nome}, sua média foi igual a {pegarMedia}! Reprovado!");
            }
        }
    

    }
}
