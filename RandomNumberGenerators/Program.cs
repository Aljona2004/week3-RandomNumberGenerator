using System;

namespace RandomNumberGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int myRandomNumber = rnd.Next(1, 11);//number 1 kuni 10

            Console.WriteLine($"Sinu juhuslik number on {myRandomNumber}");

        }
    }
}
