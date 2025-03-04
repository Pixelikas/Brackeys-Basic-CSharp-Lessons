using System;

namespace TicketsCinema
{
	public class Program
	{
		public static void Main(string[] args)
		{

            double height;
            int age;

            Console.WriteLine("Vamos ver se você pode ir na montanha russa?");

			Console.Write("Digite a sua altura (m): ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a sua idade: ");
            age = Convert.ToInt32(Console.ReadLine());

            if(height >= 1.60 || age >= 18){

                Console.WriteLine("Pode irrrrr! :D");

            }else{

                Console.WriteLine("Não pode irrrrr! :(");

            }
            
		}
	}
}