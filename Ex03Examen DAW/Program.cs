using System;
using System.Data;
using System.IO;

namespace Ex03Examen_DAW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomFitxer;


            Console.WriteLine("Nom del fitxer: ");
            nomFitxer = (Console.ReadLine() + ".txt");





            if (File.Exists(nomFitxer))
            {
                StreamReader sr = new StreamReader(nomFitxer);
                string dades = sr.ReadLine();
                
                

                while (dades != null)
                {

                    Console.Write("Nom: " + dades.Substring(0,dades.IndexOf(';')));                   
                    dades=(dades.Substring(dades.IndexOf(';') + 1));
                    Console.Write("     Primer Cognom:"+ dades.Substring(0, dades.IndexOf(';')));
                    dades = (dades.Substring(dades.IndexOf(';') + 1));
                    Console.WriteLine("    Segon Cognom: "+ dades.Substring(0, dades.IndexOf(';')));
                    Console.WriteLine("\r");
                    dades = (dades.Substring(dades.IndexOf(';') + 1));
                    Console.WriteLine("DNI: " + dades.Substring(0, dades.IndexOf(';')));
                    Console.WriteLine("\r");
                    dades = (dades.Substring(dades.IndexOf(';') + 1));
                    DateTime data = DateTime.Parse(dades);
                    DateTime actual = DateTime.Now;
                    string dataText= data.ToString("dd 'de' MMMM 'de' yyyy", new System.Globalization.CultureInfo("ca-ES"));
                    Console.WriteLine($"Data de naixement: {dataText}");
                    Console.WriteLine("\r");
                    string any = data.ToString("yyyy");
                    string anyActual = actual.ToString("yyyy"); 
                    int edat =int.Parse(anyActual) - int.Parse(any);
                    Console.WriteLine($"Edat: {edat}");
                    Console.WriteLine("\r");



                    dades = sr.ReadLine();



                }

                
                sr.Close();
            }

            else
                Console.WriteLine("El fitxer no existeix");
        }
    }
}
