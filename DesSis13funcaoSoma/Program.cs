using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesSis13funcaoSoma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escreva um numero: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("escreva o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());

            soma(n1, n2);
        }
        static void soma(double v1, double v2) 
        {
            
            double resulado = v1 + v2;
            Console.WriteLine("O resultado é de: " + resulado);
            Console.ReadKey();
        }
    }
}
