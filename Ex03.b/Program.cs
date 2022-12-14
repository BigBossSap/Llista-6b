using System;

namespace Ex03.b
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;

            Console.WriteLine("FRASE: ");
            string frase = Console.ReadLine();
            frase = frase.ToUpper();
            string abecedari = "ABCDEFGHIJKLMNOPQRSTUVXWYZ";
            string comprobades = "";



            for (int i = 0; i < frase.Length; i++)
            {

                if(abecedari[i].Contains(frase[i]))


                if (cont != 0)
                    Console.WriteLine($"Han aparegut {cont} lletres {abecedari[i].ToString().ToLower()} o {abecedari[i]}");

            }
        }
    }
}
