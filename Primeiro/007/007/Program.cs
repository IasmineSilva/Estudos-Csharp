using System;

namespace curso{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("entre com um número inteiro");
            int y = int.Parse(Console.ReadLine());

            if (y % 2 == 0){
                Console.WriteLine("Par!");
            }
            else{
                Console.WriteLine("Ímpar!");
            }

        }
    }
}