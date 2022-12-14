using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. Fer un programa que demani el resultat d'una quiniela (string de 13 posicions de la
  forma 11111X12XX211) i vagi demanant quinieles. Per cada una dirà quants encerts
  en té. Tenir en compte que l’usuari no ha de preocuparse per majúscules ni
  minúscules.*/

            string resultat, quinielaC; 
            char individual1, individual2;
            int cont = 0;

            Console.WriteLine("Quiniela guanyadora: ");
            resultat = Console.ReadLine();


            Console.WriteLine("Introdueix la teva quiniela: ");
            quinielaC = Console.ReadLine();


            if (quinielaC.Length != 13)
            {
                Console.WriteLine("Quiniela incorrecta");
                Console.WriteLine("Torna a provar: ");
                quinielaC = Console.ReadLine();
            }

            // if(!"1X2".Contains(QuinielaC[i]) ERROR
            
            
            for (int i=0; i<resultat.Length;i++)
            {
                individual1 =resultat[i];

                for (int j = 0; j < quinielaC.Length; j++);
                {
                    if (quinielaC[i] == 'x')
                        individual2 = 'X';
                    else
                    individual2 = quinielaC[i];
                }

                if (individual1 == individual2)
                    cont++;


            }

            Console.WriteLine(cont);


            



        }
    }
}
