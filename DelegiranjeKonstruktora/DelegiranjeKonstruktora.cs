using System;

namespace Vsite.CSharp
{
    class Bazna
    {
        public Bazna(int a)
        {
            A = a;
            Console.WriteLine(string.Format("Bazna.Bazna({0})", a));
        }

        public readonly int A;
    }

    class Izvedena  : Bazna
    {
        public Izvedena() : base(5)
        {
            Console.WriteLine(string.Format("Izvedena.Izvedena()"));
        }

        public readonly int B;
    }

    public class DelegiranjeKonstruktora
    {
        public static void StvoriInstancuBazneKlase()
        {
            Bazna b = new Bazna(3);
            Console.WriteLine(b.A);
        }

        public static void StvoriInstancuIzvedeneKlasePraznimKonstruktorom()
        {
            Izvedena i = new Izvedena();
            Console.WriteLine(i.A);
            Console.WriteLine(i.B);

        }

        public static void StvoriInstancuIzvedeneKlaseKonstruktoromSDvaArgumenta(int a, int b)
        {
            // nisam stigao
        }

        static void Main(string[] args)
        {
            StvoriInstancuBazneKlase();

            StvoriInstancuIzvedeneKlasePraznimKonstruktorom();

            StvoriInstancuIzvedeneKlaseKonstruktoromSDvaArgumenta(5, 7);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }

}
