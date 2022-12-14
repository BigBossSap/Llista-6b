using System;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5.Donat un string, dins d’una variable de tipus string, feu que tregui tots els espais,
deixant - la a la mateixa variable.*/



            //Console.WriteLine("frase");
            //string frase = Console.ReadLine();

            //frase = frase.Replace(" ", "");

            //Console.WriteLine(frase);


            Console.WriteLine("frase");
            string frase = Console.ReadLine();


            while (frase.Contains(' '))
            {

                frase = frase.Substring(0, frase.IndexOf(' ')) + frase.Substring(frase.IndexOf(' ') + 1);
                
            }

            Console.WriteLine(frase);
            
        }       
    }
}
