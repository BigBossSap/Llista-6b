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

            string isbn;

            Console.WriteLine("ISBN: ");
            isbn = Console.ReadLine();

            if(isbn.Length>11)
                Console.WriteLine("Invalid");







        }
    }
}
