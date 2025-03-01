using System;

namespace MediaNumeros
{
	public class Program
	{
		public static void Main(string[] args)
		{

            double numberOne, numberTwo, numberThree, numbersAverage;
            int numbersQuantity = 3;

			Console.Write("Digite o primeiro número: ");
            numberOne = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numberTwo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            numberThree = Convert.ToDouble(Console.ReadLine());

            numbersAverage = (numberOne + numberTwo + numberThree) / numbersQuantity;

            Console.WriteLine("Média: " + numbersAverage);
            
		}
	}
}