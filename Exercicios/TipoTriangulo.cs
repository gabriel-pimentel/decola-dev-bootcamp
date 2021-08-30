using System; 

class Desafio {

        public static void Main()
        {
            string[] s = Console.ReadLine().Split(' ');
            
            double[] arr = Array.ConvertAll(s, double.Parse);
            Array.Sort(arr);
            Array.Reverse(arr);
            
            double a = arr[0];
            double b = arr[1];
            double c = arr[2];
            
              //continue a solucao
            if (a >= (b + c)) {
              Console.WriteLine("NAO FORMA TRIANGULO");
            } 
              
            else if ( Math.Pow(a, 2) == (Math.Pow(b, 2) + Math.Pow(c,2))) {
                Console.WriteLine("TRIANGULO RETANGULO");
              
            }
                
            else if ( Math.Pow(a, 2) > (Math.Pow(b, 2) + Math.Pow(c,2))) {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            } 
            else if ( Math.Pow(a, 2) < (Math.Pow(b, 2) + Math.Pow(c,2))){
              Console.WriteLine("TRIANGULO ACUTANGULO");
            }  
                
            if ((a == b) && (b == c))
                Console.WriteLine("TRIANGULO EQUILATERO");
            if (((a == b) || (b == c)) && (a != c))
                Console.WriteLine("TRIANGULO ISOSCELES");
            
              
            Console.ReadLine();
        }
}
