using FizzBuzz;
using System.Runtime.CompilerServices;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gra FizzBuzz.");
            string userChoice;
            FizzBuzz game = new FizzBuzz();

            while (true)
            {
                Console.WriteLine("Podaj swoją liczbę. (wpisz e żeby zakończyć).");
                userChoice = Console.ReadLine();
                if (userChoice == "e" || userChoice == "E")
                {
                    Console.WriteLine("Koniec gry.");
                    break;
                }
                
                try
                {
                    Console.WriteLine(game.GameFizzBuzz(int.Parse(userChoice)));
                }
                catch
                {
                    Console.WriteLine("Wprowadzona wartość jest niepoprawna");
                }
            }
        }
            
    }
}