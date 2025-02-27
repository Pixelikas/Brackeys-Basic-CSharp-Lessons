using System;

namespace SomaNumeros
{
	public class Program
	{
		public static void Main(string[] args)
		{

            double numberOne, numberTwo, numberDiv;

			Console.Write("Digite o primeiro número: ");
            numberOne = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numberTwo = Convert.ToDouble(Console.ReadLine());

            numberDiv = numberOne / numberTwo;

            Console.WriteLine("Divisão: " + numberDiv);
            
		}
	}
}