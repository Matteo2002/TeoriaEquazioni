using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public static class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            bool risp = true;

            if (a == 0)
            {
                risp = false;
            } 
            else
            {
                risp = true;
            }
            return risp;
        }

        public static bool IsInconsisted(double a, double b)
        {
            bool risp;

            if (a==0 && b == 0)
            {
                risp = true;
            }
            else
            {
                risp = false;
            }
            return risp;
        }

        public static bool IsDegree2(double a)
        {
            bool risp;

            if (a==0)
            {
                risp = false;
            }
            else
            {
                risp = true;
            }
            return risp;
        }
        
        public static double Delta(double a, )
    }
}
