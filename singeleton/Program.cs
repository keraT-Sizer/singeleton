using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil m = Autofabrik.MachEines();
            m.Name = "Tillmanns";
            Automobil x = Autofabrik.MachEines();
       

            Console.WriteLine(m.Name);
            Console.WriteLine(m.GetHashCode());
            Console.WriteLine(x.Name);
            Console.WriteLine(x.GetHashCode());
            Console.ReadLine();
        }
    }
    class Automobil
    {
        public string Name { get; set; }
    }
    class Autofabrik
    {
        private static Automobil automobil = null;
        public static Automobil MachEines()
        {
            if (automobil == null)
            {
                automobil = new Automobil();
            }
            return automobil; 
        }
    }
}
