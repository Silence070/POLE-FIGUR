using System;

class Program
{
    
    static double ParseDouble(string tekst)
    {
        double liczba;

        while (true)
        {
            Console.WriteLine(tekst);

            if (double.TryParse(Console.ReadLine(), out liczba))
            {
                return liczba;
            }

            Console.WriteLine("Blad!");
        }
    }

    
    static int Silnia(int a)
    {
        if (a <= 1)
            return 1;
        else
            return Silnia(a - 1) * a;
    }

   
    static double PoleProstokata(double a, double b)
    {
        return a * b;
    }

 
    static double PoleKwadratu(double a)
    {
        return a * a;
    }

   
    static double PoleTrojkata(double a, double h)
    {
        return a * h / 2;
    }

 
    static double PoleKola(double r)
    {
        return 3.14 * r * r;
    }

    static void Main()
    {
        int wybor = -1;

        while (wybor != 0)
        {
            Console.WriteLine("");
            Console.WriteLine("1. Silnia");
            Console.WriteLine("2. Pole prostokata");
            Console.WriteLine("3. Pole kwadratu");
            Console.WriteLine("4. Pole trojkata");
            Console.WriteLine("5. Pole kola");
            Console.WriteLine("0. Wyjscie");

            Console.Write("Wybierz opcje: ");

            if (!int.TryParse(Console.ReadLine(), out wybor))
            {
                Console.WriteLine("Niepoprawna opcja!");
                wybor = -1;
                continue;
            }

            switch (wybor)
            {
                case 1:
                    Console.Write("Podaj liczbe: ");
                    int a;

                    if (!int.TryParse(Console.ReadLine(), out a) || a < 0 || a > 12)
                    {
                        Console.WriteLine("Podaj liczbe od 0 do 12");
                    }
                    else
                    {
                        Console.WriteLine("Silnia = " + Silnia(a));
                    }
                    break;

                case 2:
                    double b = ParseDouble("Podaj bok a:");
                    double c = ParseDouble("Podaj bok b:");

                    Console.WriteLine("Pole = " + PoleProstokata(b, c));
                    break;

                case 3:
                    double d = ParseDouble("Podaj bok kwadratu:");

                    Console.WriteLine("Pole = " + PoleKwadratu(d));
                    break;

                case 4:
                    double e = ParseDouble("Podaj podstawe:");
                    double h = ParseDouble("Podaj wysokosc:");

                    Console.WriteLine("Pole = " + PoleTrojkata(e, h));
                    break;

                case 5:
                    double r = ParseDouble("Podaj promien:");

                    Console.WriteLine("Pole = " + PoleKola(r));
                    break;

                case 0:
                    Console.WriteLine("Koniec programu.");
                    break;

                default:
                    Console.WriteLine("Nie ma takiej opcji!");
                    break;
            }
        }
    }
}
