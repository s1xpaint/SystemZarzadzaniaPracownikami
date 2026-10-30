using System;

namespace SystemZarzadzaniaPracownikami
{
    class Pracownik
    {
        private decimal wynagrodzenie;
        protected string imie;
        internal string dzial;

        public Pracownik(string imie, string dzial, decimal wynagrodzenie)
        {
            this.imie = imie;
            this.dzial = dzial;
            this.wynagrodzenie = wynagrodzenie;
        }

        public void PokazDane()
        {
            Console.WriteLine($"Pracownik: {imie}, Dział: {dzial}, Wynagrodzenie: {wynagrodzenie} zł");
        }

        public void ZmienWynagrodzenie(decimal kwota)
        {
            if (kwota > 0)
            {
                wynagrodzenie = kwota;
                Console.WriteLine($"Zmieniono wynagrodzenie dla {imie} na {wynagrodzenie} zł.");
            }
            else
            {
                Console.WriteLine("Błąd: Kwota wynagrodzenia musi być większa od zera!");
            }
        }
    }

    class Kierownik : Pracownik
    {
        public Kierownik(string imie, string dzial, decimal wynagrodzenie)
            : base(imie, dzial, wynagrodzenie)
        {
        }

        public void PrzedstawSie()
        {
            Console.WriteLine($"Cześć, jestem kierownikiem i mam na imię {imie}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pracownik pracownik = new Pracownik("Janek", "IT", 6500m);
            Kierownik kierownik = new Kierownik("Marta", "Logistyka", 11000m);

            pracownik.PokazDane();
            kierownik.PokazDane();
            kierownik.PrzedstawSie();

            Console.WriteLine();


            pracownik.ZmienWynagrodzenie(-500m);
            pracownik.ZmienWynagrodzenie(7500m);
            pracownik.PokazDane();

            Console.WriteLine();

            Console.WriteLine($"Dział pracownika odczytany w Main: {pracownik.dzial}");

            Console.ReadKey();
        }
    }
}