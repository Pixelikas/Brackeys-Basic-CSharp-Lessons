using System;

namespace PotenciaNumero
{
	public class Program
	{
		public static void Main(string[] args)
		{

            for(int i=1; i < 10; i++){

                double result = Math.Pow(2, i);
            	Console.WriteLine("Potência de 2: " + result);

			}      
       
		}
	}
}