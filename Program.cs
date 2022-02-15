using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasljedivanje3
{
    class ProgramskiJezik
    {
        double postotak;

        public double Postotak { get => postotak; set => postotak = value; }
    }
    class Proceduralni : ProgramskiJezik
    {
        public Proceduralni(double x)
        {
            Postotak = x;
        }
    }

    class Objektni : ProgramskiJezik
    {
        public Objektni(double y)
        {
            Postotak = y;
        }
    }

    class Funkcionalni : ProgramskiJezik
    {
        public Funkcionalni(double z)
        {
            Postotak = z;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proceduralni postotak: ");
            double postotakX = Convert.ToDouble(Console.ReadLine());
            Proceduralni x = new Proceduralni(postotakX);

            Console.WriteLine("Objektni postotak: ");
            double postotakY = Convert.ToDouble(Console.ReadLine());
            Proceduralni y = new Proceduralni(postotakY);

            Console.WriteLine("Funkcionalni postotak: ");
            double postotakZ = Convert.ToDouble(Console.ReadLine());
            Proceduralni z = new Proceduralni(postotakZ);

            if ( x + y + z ==100)
            {

            }

        }
    }
}
