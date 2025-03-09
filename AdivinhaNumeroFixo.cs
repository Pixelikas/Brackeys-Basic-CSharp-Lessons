using System;

namespace AdivinhaNumeroFixo
{
	public class Program
	{
		public static void Main(string[] args)
		{

            int secretNumber = 100;
            int playerNumber = 0;

            while(playerNumber != secretNumber){

                Console.Write("Digite um palpite de número: ");
                playerNumber = Convert.ToInt32(Console.ReadLine());
                
                if(playerNumber == secretNumber){

            	    Console.WriteLine("Você acertou! Parabéns :D");
                    break;

                }else{

                    Console.WriteLine("Você errou!");

                }
                
			}      
       
		}
	}
}