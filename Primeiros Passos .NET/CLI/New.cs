using System;
using System.IO;


namespace CLI
{
    
    class New
    {
        static void Main(string[] args)
        {
            string currentDirectoryPath = Directory.GetCurrentDirectory();
            Console.WriteLine("Your current directory is {0}", path);
            
            Console.WriteLine("Type the name of your application:");
            string newProjectName = Console.ReadLine();

            string generated = System.IO.Path.Combine(currentDirectoryPath, "Generated Apps");

            //if ()
            System.IO.Directory.CreateDirectory(newProjectPath);

        }
    }
}
