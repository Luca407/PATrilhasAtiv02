using System;

namespace MultiEntreDoisNumeros
{
    class Program
    {
        public static void Main(string[] args)
        {
        	
           	Console.WriteLine("Digite o primeiro número: ");
           	double x = Convert.ToDouble(Console.ReadLine());
           	
           	Console.WriteLine("Digite o segundo número: ");
           	double y = Convert.ToDouble(Console.ReadLine());
           	
           	double multi = x*y;
           	
           	Console.WriteLine("A multiplicação de " + x + " e " + y + " é: " + multi);
           	Console.ReadKey(true);
        }
    }
}
