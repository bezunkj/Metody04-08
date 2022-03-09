using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody04
{
    class CelaCisla
    {
        public int Mocnina(int zaklad, int exponent)
        {
            if(exponent < 0)
            {
                exponent *= -1;
                zaklad = 1 / zaklad;
            }

            int vysledek = 1;
            for(int i = 0; i < exponent; i++)
            {
                vysledek *= zaklad;
            }

            return vysledek;
        }
    }
}
