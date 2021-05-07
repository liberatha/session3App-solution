using System;

namespace session3App
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            string[] food = new string[4];

            food [0] = "Robster Miano";
            food [1] = "Smashed Potato Salad";
            food [2] = "Vegan Sushi";
            food [3] = "Grilled Salmon";

            float[] Price= new float[4];
            Price[0]=256.4f;
            Price[1]=102.1f;
            Price[2]=152.8f;
            Price[3]=93.9f;

            for (int i =0, j = 0;
                 i < food.Length && j< Price.Length; i++, j++)
            {
               Console.WriteLine("food; "+food [i]+ "price is"+Price[j] ) ;


              
               if (Price [j]<=150.00)
               {
                 Console.WriteLine("John can afford food; "+food [i]+ "price is"+Price[j] ) ;  
               }
               else
               {
                   Console.WriteLine("John can not afford food; "+food [i]+ "price is"+Price[j] ) ;
               }
            
            }

            

        }
    }
}
