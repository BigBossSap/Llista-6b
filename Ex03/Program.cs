using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fer un programa que demani una frase i digui quantes lletres de cada hi ha. Feu servir
  que el codi ascii de la 'A' = 65 ... 'Z' = 92. Feu-ho també utilitzant el mètode Contains
  */
            int cont = 0;

            Console.WriteLine("FRASE: ");
            string frase = Console.ReadLine();
            frase = frase.ToUpper();
            string abecedari = "ABCDEFGHIJKLMNOPQRSTUVXWYZ";



            for (int i=0;i<abecedari.Length;i++)
            {

                cont = 0;
                for (int j = 0; j < frase.Length; j++)
                    if (abecedari[i] == frase[j])
                        cont++;

                if (cont!=0)
                Console.WriteLine($"Han aparegut {cont} lletres {abecedari[i].ToString().ToLower()} o {abecedari[i]}");

            }

            
            
        }
    }
}
