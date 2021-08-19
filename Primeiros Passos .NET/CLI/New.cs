using System;
using System.IO;


namespace CLI
{
    
    class New
    {

        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine("Your current directory is {0}", path);
        }
    }
}
