using System;

namespace TicketsCinema
{
	public class Program
	{
		public static void Main(string[] args)
		{

            int ticketPrice = 5;
            int cashPayment, changeMoney;

            Console.WriteLine("Bem-vindo! Tickets custam R$5.");

			Console.Write("Digite o valor em dinheiro: ");
            cashPayment = Convert.ToInt32(Console.ReadLine());

            if(cashPayment < ticketPrice){

                Console.WriteLine("O dinheiro não é suficiente! :(");

            }else if(cashPayment == ticketPrice){

                Console.WriteLine("Aqui está o seu ticket. Bom filme! :D");

            }else if(cashPayment > ticketPrice){

                changeMoney = cashPayment - ticketPrice;
                Console.WriteLine("Aqui está o seu ticket e R$" + changeMoney + " de troco! ;)");

            }
            
		}
	}
}