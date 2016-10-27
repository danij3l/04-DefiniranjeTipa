using System;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
        int broj = 3;

        public void IspišiČlan()
        {
            Console.WriteLine(broj);
        }
    }


    struct MojaStruktura
    {
        private string tekst;

        public MojaStruktura(string tekst)
        {
            this.tekst = "Moja struktura";
        }

        public void IspišiČlan()
        {
            Console.WriteLine(this.tekst);
        }
    }


    public class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            MojaKlasa mk = new MojaKlasa();
            mk.IspišiČlan();
        }

        public static void IspišiČlanStrukture()
        {
            MojaStruktura ms = new MojaStruktura();
            ms.IspišiČlan();
        }

        static void Main(string[] args)
        {
            IspišiČlanKlase();

            IspišiČlanStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
