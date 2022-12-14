using System;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Donat un string que conté el nom i cognom d’una persona amb format
nom;cognom1;cognom2, obtenir 3 strings diferents amb el nom i els dos cognoms. Per
exemple:
Resoleu el problema amb i sense el mètode IndexOf.
a. "Lloni;me lavo;la cara" → n="Lloni" c1="me lavo" c2="la cara"
b. "Llojan;cruif;" → n="Llojan" c1="cruif" c2=""
c. ";Betoven;" → n="" c1="Betoven" c2=""*/

            //amb indexof

            string nom, cognom1, cognom2;
            string frase;
            Console.WriteLine("Frase: ");
            frase = Console.ReadLine();

           
                //nom = frase.Substring(0, (frase.IndexOf(';')));
                //frase = frase.Substring(frase.IndexOf(';') + 1);
                //cognom1 = frase.Substring(0, (frase.IndexOf(';')));
                //frase = frase.Substring(frase.IndexOf(';') + 1);
                //cognom2 = frase;

                //Console.WriteLine($"Nom: {nom}");
                //Console.WriteLine($"Primer cognom: {cognom1}");
                //Console.WriteLine($"Segon cognom {cognom2}");
            

            //versio per molts ;

            while (frase.Contains(';'))
            {
                Console.WriteLine(frase.Substring(0, (frase.IndexOf(';'))));
                frase= frase.Substring(frase.IndexOf(';') + 1);
            }
            if (frase!="")
                Console.WriteLine(frase);



            //sense indexof

            //string nom2="", cognom11="", cognom12="";
            //string frase2, frase3="";
            //bool nomE = true;
            //Console.WriteLine("Frase2: ");
            //frase2 = Console.ReadLine();

            //for (int i=0; i<frase2.Length-1;i++)
            //{

            //    while (nomE == true)
            //    {
            //        nom2 += frase2[i];
            //        i++;
            //        if (frase2[i] == ';')
            //            nomE = false;
                    

            //    }
            //    if (nomE == false)
            //        frase3 += frase2[i];

            //}

            
            }
    
}    }  
        
        

