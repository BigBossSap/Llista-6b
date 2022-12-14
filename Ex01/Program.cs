using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*. Fer un programa C# que validi un ISBN (International Standard Book Number) de 9
xifres. El programa ens demanarà un string format per 9 digits, un guió i el digit de
control (un char) i si és incorrecte ens ho dirà i ho tornarà a demanar tot.
De vegades el guió no el posen.
El ISBN 843654201-0 és correcte. Per mirar-lo farem
8*1+4*2+3*3+6*4+5*5+4*6+2*7+0*8+1*9=121
121 MOD 11 = 0  dígit de control és 0. Si fos 10 seria X.*/

            string isbn, num;
            int individual, j = 1;
            char caracter;
            int caracterNum;
            int suma = 0;
            
            Console.WriteLine("ISBN: ");
            isbn = Console.ReadLine();

            while (isbn.Length!=11)
            {
                Console.WriteLine("Invalid");
                Console.WriteLine("ISBN: ");
                isbn = Console.ReadLine();
            }
           
            num = isbn.Substring(0, 9);
            Console.WriteLine(num);
            caracter = isbn[10];
            
            for (int i=0; i<num.Length;i++)
            {
                
                individual = Convert.ToInt32(num[i]) -'0';
                Console.WriteLine(individual);
                suma += individual * j;
                j++;
               
                 
            }

            caracterNum = Convert.ToInt32(caracter)-'0';
            if (caracter == 'X' || caracter == 'x')
                caracterNum = 10;
            if (suma%11==caracterNum)
                Console.WriteLine("ISBN Correcte");
            else
                Console.WriteLine("ISBN Incorrecte");
            







        }
    }
}
