using System;

namespace DivisaoEntreDoisNumeros
{
    class Program
    {
        public static void Main(string[] args)
        {
        	
           	Console.WriteLine("Digite o primeiro numero: ");
           	double x = Convert.ToDouble(Console.ReadLine());
           	
            Console.WriteLine("Digite o segundo numero: ");
           	double y = Convert.ToDouble(Console.ReadLine());
           	
           	double divisao = x/y;
           	
           	Console.WriteLine("A divisao dentre " + x + " e " + y + " é: " + divisao);
           	Console.ReadKey(true);
        }
    }
}
