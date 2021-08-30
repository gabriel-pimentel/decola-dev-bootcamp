using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            //complete declarando as variáveis
            int a = Convert.ToInt32(vet[0]);
            int b = Convert.ToInt32(vet[1]);
            int c = Convert.ToInt32(vet[2]);

            int MAIORAB = (a + b + Math.Abs(a - b))/2;

            int MAIOR = (c + MAIORAB + Math.Abs(c - MAIORAB)) / 2;

            Console.WriteLine($"{MAIOR} eh o maior");
                        
        }
    }
