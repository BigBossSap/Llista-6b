using System;
using System.IO;

namespace Ex02Examen_Daw
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            string nomFitxer;
            

            Console.WriteLine("Nom del fitxer: ");
            nomFitxer = (Console.ReadLine()+".txt");
            

           


            if (File.Exists(nomFitxer)) 
            {
                StreamReader sr = new StreamReader(nomFitxer);
                string dades = sr.ReadLine();
                bool dniTrobat = false;
                Console.WriteLine("Dni a buscar: ");
                string dni = Console.ReadLine();

                while (dades != null)
            {

                if(dades.Contains(dni))
                {
                    Console.WriteLine(dades.Substring(0, dades.IndexOf(';')) + "-" + dni);
                    dniTrobat = true;   
                }


                dades = sr.ReadLine();



            }

            if (!dniTrobat)
                Console.WriteLine($"DNI, {dni},  no trobat!");
                sr.Close();
            }

            else
                Console.WriteLine("El fitxer no existeix");

           
        }
    }
}
