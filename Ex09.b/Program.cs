using System;

namespace Ex09.b
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double contA = 0, contF=0, cont=0;
            Console.WriteLine("FRASE: ");
            string frase = Console.ReadLine();


            for(int i = 0; i < frase.Length; i++){

                if ("a".Contains(frase[i]))
                    contA++;
                if ("f".Contains(frase[i]))
                    contF++;
                if (frase[i] != ' ')
                    cont++;
            }

            if ((contA / cont * 100 >= 10 && contA / cont * 100 <= 12) && (contF / cont * 100 >= 4 && contF / cont * 100 <= 6))
                Console.WriteLine("Es catala");

            

        }
    }
}
