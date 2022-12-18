using System;
using System.IO;

namespace Ex_10.b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"poema.txt");


            string rima, poema;
            int cont = 0;

            Console.WriteLine("Rima: ");
            rima = Console.ReadLine();


            poema = sr.ReadLine();

            while (poema != "FI")
            {
                if (poema.Substring(poema.Length - 3, 3).ToUpper().Contains(rima.ToUpper()))
                    cont++;

                poema = sr.ReadLine();
            }

            Console.WriteLine(cont);
            sr.Close();
        }
    }
}
