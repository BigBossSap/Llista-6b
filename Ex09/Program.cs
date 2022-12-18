using System;
using System.Runtime.ConstrainedExecution;

namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            9.Donat un text, llegit de cop amb Console.ReadLine, dir si és possible que estigui en
            // català, tenint en compte que un text en català té(amb probabilitat del 95 %) entre el 4 i
            //6 per cent de lletres f i entre el 10 i el 12 d’as.
            //Fer - lo recorreguent tot l’string, fer-lo també utilitzant IndexOf



            double contA = 0, contF = 0, contLletres = 0;

            Console.WriteLine("FRASE: ");
            string frase = Console.ReadLine();
            frase = frase.ToUpper();
            string abecedariA = "A";
            string abecedariF = "F";

            for(int l=0;l<frase.Length;l++)
            {
                if (frase[l]!=' ')
                    contLletres++;
            }

            for (int i = 0; i < abecedariA.Length; i++)
            {

                contA = 0;
                for (int j = 0; j < frase.Length; j++)
                    if (abecedariA[i] == frase[j])
                        contA++;
                for (int k = 0; k < frase.Length; k++)
                    if (abecedariF[i] == frase[k])
                        contF++;
                                  
            }

            if ((contA/contLletres*100>=10&& contA / contLletres * 100 <= 12)&& (contF / contLletres * 100 >= 4 && contF / contLletres * 100 <= 6))
                Console.WriteLine("Es catala");

            double percentA = contA / contLletres * 100;
            double percenF = contF / contLletres * 100;
            Console.WriteLine(percenF);
            Console.WriteLine(percentA);
            Console.WriteLine(contA);
            Console.WriteLine(contF);
            Console.WriteLine(contLletres);
        }
    }
}
