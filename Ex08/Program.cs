using System;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*8. Donada una llista de llibres, de la forma nomllibre preu (intro) nomllibre preu (intro) …
 FI, dir el preu del llibre amb nom alfabèticament major. Podem suposar que no es
 repeteixen els noms.
 */

            string llibre;
            string llibre2="{",llibreOrdenat="";
            string preu, preuOrdenat="";

            Console.WriteLine("Llibre:");
            llibre = Console.ReadLine();
            Console.WriteLine("Preu: ");
            preu = Console.ReadLine();

            while (llibre2!="fi")
            {
                


                if (llibre[0] > llibre2[0])
                {
                    llibreOrdenat = llibre2;
                    preuOrdenat = preu;
                    
                }

                


                Console.WriteLine("Llibre:");
                llibre2 = Console.ReadLine();

                if (llibre2 != "fi")
                {
                    Console.WriteLine("Preu: ");
                    preu = Console.ReadLine();
                }



            }

            Console.WriteLine($" El preu del llibre {llibreOrdenat} es de {preuOrdenat}");
            


        }
    }
}
