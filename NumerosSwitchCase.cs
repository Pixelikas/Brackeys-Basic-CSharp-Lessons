using System;

namespace NumerosSwitchCase
{
	public class Program
	{
		public static void Main(string[] args)
		{

            int number;

            Console.Write("Digite um número de 1 a 5: ");
            number = Convert.ToInt32(Console.ReadLine());

            switch(number){

                case 1:
                    Console.WriteLine("Um! :D");
                    break;

                case 2:
                    Console.WriteLine("Dois! :D");
                    break;

                case 3:
                    Console.WriteLine("Três! :D");
                    break;

                case 4:
                    Console.WriteLine("Quatro! :D");
                    break;

                case 5:
                    Console.WriteLine("Cinco! :D");
                    break;

                default:
                    Console.WriteLine("Número não válido! =~");
                    break;

            }
            
		}
	}
}