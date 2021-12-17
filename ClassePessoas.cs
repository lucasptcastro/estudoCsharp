using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudoCsharp
{
    public class ClassePessoas
    {
        //Atributos da classe "ClassePessoas"
        public string nome;
        public int idade;

        //Métodos da classe "ClassePessoas"
        public void mensagem()
        {
            Console.WriteLine("Olá, " + nome + "! Você tem " + idade + " anos, correto?");
        }
    }
}
