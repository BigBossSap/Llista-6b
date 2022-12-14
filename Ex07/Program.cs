using System;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7. Donada una frase dir si ha estat introduïda en majúscules, en minúscules o “barrejada”*/

            string frase;
            
            Console.WriteLine("frase");

            frase = Console.ReadLine();

           
            if(frase==frase.ToUpper())
                Console.WriteLine("Majus");
            else if (frase==frase.ToLower())
                Console.WriteLine("Minus");
            else
                Console.WriteLine("Barrejadesi");

           
        }
    }
}
