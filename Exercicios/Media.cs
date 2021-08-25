using System; 

class Media {

    static void Main(string[] args) { 

            //implente sua solução aqui
            Decimal total = Convert.ToDecimal(0.0);
            Decimal nota, media;
            string input;
            int notasValidas = 0;
            
            do 
            {
              input = Console.ReadLine();
              nota = Convert.ToDecimal(input);
              
              if( (nota > Convert.ToDecimal(10.0)) || (nota < Convert.ToDecimal(0.0)) ) {
                Console.WriteLine("nota invalida");
              }
              else {
                notasValidas++;
                total += nota;
              }
            
            } while (notasValidas < 2);
            
            media = total / 2;
            Console.WriteLine("media = {0}", Math.Round(media, 2));
    }

}