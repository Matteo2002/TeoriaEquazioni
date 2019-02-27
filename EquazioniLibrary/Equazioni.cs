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

        public static bool IsInconsisted(double a, double b)
        {
            bool risp = true;
            if (a == 0 && b == 0)
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
            bool risp = true;

            if (a != 0)
            {
                risp = false;
            }

            else
            {
                risp = false;
            }

            return risp;
        }     

        public static double Delta(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }

        public static string EquationDegree1(double a, double b)
        {
            string risp ="";

            if (IsInconsisted(a, b)) 
            {
                risp = "L'equazione è indeterminata";
            }

            if (a != 0 && b == 0)
            {
                risp = "L'equazione è impossibile";
            }

            else
            {
                Double c= -b / a;
            }

            return risp;
        }
    }
}
