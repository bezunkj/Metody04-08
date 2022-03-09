using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody04
{
    class CelaCisla
    {
        public static int Mocnina(int zaklad, int exponent)
        {
            // nejlepsi moznost
            bool zaporExp = exponent < 0;
            exponent = Math.Abs(exponent);

            int vysledek = 1;
            for(int i = 0; i < exponent; i++)
            {
                vysledek *= zaklad;
            }

            if (zaporExp) vysledek = 1 / vysledek;
            
            return vysledek;
        }

        public static int Faktorial(int x)
        {

            int vysledek = 1;

            for(int i = x; i > 0; i--)
            {
                vysledek *= i;
            }

            return vysledek;
        }

        public static int CifLichSoucet(int x)
        {
            int cifra;

            int soucet = 0;

            while(x > 0)
            {
                cifra = x % 10;
                x = x / 10;
                if (cifra %2 != 0)
                {
                    soucet += cifra;
                }

               
            }

            return soucet;
        }
    }
}
