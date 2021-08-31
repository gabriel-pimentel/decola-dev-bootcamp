using System; 
using System.Collections.Generic; 

class URI {

    static void Main(string[] args) { 
            
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int escolha = 0;
            
            
            while(escolha != 4){    
                escolha = Convert.ToInt32(Console.ReadLine());
                
                switch (escolha)
                {
                    case 1:
                      alcool += 1;
                      break;
                    case 2:
                      gasolina += 1;
                      break;
                    case 3:
                      diesel += 1;
                      break;
                    case 4:
                        Console.WriteLine($"MUITO OBRIGADO");
                        break;
                    default:                       
                        continue;
                }
            }          
      
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
    }

}
