using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
           
            //complete o código com sua solução

            for (int i = 1; i <= Convert.ToInt32(vet[1]); i++)
            {
                Console.Write(i);
                if (i % Convert.ToInt32(vet[0]) == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
