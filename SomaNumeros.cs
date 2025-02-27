using System;

namespace SomaNumeros
{
	public class Program
	{
		public static void Main(string[] args)
		{

            int numberOne, numberTwo, numberSum;

			Console.Write("Digite o primeiro número: ");
            numberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numberTwo = Convert.ToInt32(Console.ReadLine());

            numberSum = numberOne + numberTwo;

            Console.WriteLine("Soma: " + numberSum);
            
		}
	}
}
