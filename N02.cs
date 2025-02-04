using System;

namespace MultiEntreDoisNumeros
{
    class Program
    {
        public static void Main(string[] args)
        {
        	
           	Console.WriteLine("Digite um número: ");
           	double x = Convert.ToDouble(Console.ReadLine());
           	
           	double dobro = x*2;
           	
           	Console.WriteLine("A multiplicação de " + x + " é: " + dobro);
           	Console.ReadKey(true);
        }
    }
}
