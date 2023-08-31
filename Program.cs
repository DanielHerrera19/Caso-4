using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TI;
            string DI;
            string TU;
            double PAG;
            double IMP;
            double TOT;

            Console.WriteLine("Tiempo: ");
                TI = int.Parse(Console.ReadLine());
            Console.WriteLine("Tipo del dia: ");
                DI = Console.ReadLine();
            Console.WriteLine("Turno: ");
                TU = Console.ReadLine();

            if (TI < 5)
            {
                PAG = TI * 1;
            }
            else if (TI < 8)
            {
                PAG = (TI - 5) * 0.8 + 5;
            }
            else if (TI <= 10)
            {
                PAG = (TI - 8) * 0.7 + 7.4;
            }
            else
            {
                PAG = (TI - 10) * 0.5 + 8.8;
            }

            if (DI == "DOM")
            {
                IMP = PAG * 0.5;
            }
            else if (TU == "M")
            {
                IMP = PAG * 0.15;
            }
            else
            {
                IMP = PAG * 0.10;
            }

            TOT = PAG + IMP;

            Console.WriteLine("El pago: " + PAG);
            Console.WriteLine("EL impuesto: " + IMP);
            Console.WriteLine("Total: " + TOT);

        }
    }
}