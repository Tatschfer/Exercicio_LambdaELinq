using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercícios Lambda Expression

            //Verificar se um número é par
            Func<int, bool> par = (x) => x % 2 == 0;  //int -> entrada, bool -> saida
            bool resultado = par(5);
            Console.WriteLine(resultado);

            //Calcular o quadrado de um número
            Func<int, int> quadrado = (x) => x * x;
            int resulQuadrado = quadrado (4);
            Console.WriteLine(resulQuadrado);

            //Converter string para maiúsculo
            Func<string, string> converter = (x) => x.ToUpper();
            string output = converter("teste fer");
            Console.WriteLine(output);
        }
    }
}
