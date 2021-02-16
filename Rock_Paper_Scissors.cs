using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = " ";
            Console.Write("Choose your move:(1)Rock (b)Paper (c)Scissors: ");
            choice = Console.ReadLine();
            Random rande = new Random();
            int dice;
            dice = rande.Next(1, 4);


            switch (dice)
            {
                case 1: 
                    Console.WriteLine("Its a tie!");
                    break;

            }

        }
    }
}
