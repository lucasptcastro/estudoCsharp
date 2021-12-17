using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIÁVEIS

            /*int numInt = 10;
            int numInt2 = -10;

            double nummDoub = 10.5;
            double nummDoub2 = -10.5;

            string frase = "salva tudo";
            string frase2 = "tem que usar aspas duplas";

            bool verdade = true;
            bool mentira = false;*/


            // ClassePessoas objPessoa = new ClassePessoas(); // Importou a ClassePessoas e criou o objeto "objPessoa"
            // objPessoa.nome = "Lucas"; // Definiu o atributo "nome", criado na ClassePessoas, como "Lucas"
            // objPessoa.idade = 20; // Definiu o atributo "idade", criado na ClassePessoas, como "20
            // objPessoa.mensagem(); // Iniciou a função "mensagem" da ClassePessoas
        
            
            Aluno a = new Aluno();
            a.nome = "Lucas";
            a.nota1 = 7;
            a.nota2 = 8.5;
            a.Mensagem();
        }
    }
}
