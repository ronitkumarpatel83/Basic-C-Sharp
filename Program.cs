using System;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Roca");
            Console.WriteLine("Starting Point");
            Console.WriteLine("Earth to Planet Roca");
            Console.WriteLine("Thanos has been seen in his Home Planet");
            Human human = new Human();
            human.HumanDetails();
            SwapTwoNumber swapTwoNumber = new SwapTwoNumber();
            swapTwoNumber.SwapNumbers();


            Console.ReadLine();

        }


    }
}
