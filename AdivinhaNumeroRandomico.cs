using System;

namespace AdivinhaNumeroRandomico
{
	public class Program
	{
		public static void Main(string[] args)
		{

            for(int i=1; i <= 5; i++){

                Random secretNumber = new();
                Console.WriteLine("Número randômico inteiro entre 0 e 100: " + secretNumber.Next(0,100));

            }
       
		}
	}
}