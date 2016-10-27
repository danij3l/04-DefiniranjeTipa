using System;

namespace Vsite.CSharp.StatičkiČlanovi
{
    public class BrojačInstanci
    {
        static int brojac = 0;

        public static void IspišiBrojStvorenihObjekata()
        {
            Console.WriteLine(brojac);
        }

        int instanca;
        public BrojačInstanci()
        {
            instanca = ++brojac;
        }

        public void IspišiRedniBrojObjekta()
        {
            Console.WriteLine(instanca);
        }
    }
}
