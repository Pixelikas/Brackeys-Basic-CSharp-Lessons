using System;

namespace PotenciaNumeroQuantidade
{
	public class Program
	{
		public static void Main(string[] args)
		{

            Console.Write("Quantos números deseja ver a potência? ");
            int count = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i <= count; i++){

                double result = Math.Pow(2, i);
            	Console.WriteLine("Potência de 2: " + result);

			}      
       
		}
	}
}