using System;

// Cele:

/*
Program: Kalkulator
Funkcje:
    - Wprowadź a i b    V
    - Wypisz a i b, oraz daj użytkownikowi możliwość wyboru dalszych opcji V
    - Dodawanie V
    - Odejmowanie V
    - Mnożenie V
    - Dzielenie V
*/

// Tworzymy obiekt programu, razem z instancją Main

class Program
{
    public int dodawanie(int num1, int num2)
    {
        return num1 + num2;
    }

    public int odejmowanie(int num1, int num2)
    {
        return num1 - num2;
    }

    public int mnozenie(int num1, int num2)
    {
        return num1 * num2;
    }

    public int dzielenie(int num1, int num2)
    {
        return num1 / num2;
    }
    public static void Main(string[] args)
    {
        //Tutaj znajdą się wszystkie funkcje wywołuję pozostałe instancje
        //Deklarujemy że to jest obiekt
        Program program = new Program();
        int num1;
        int num2;

        //Odpytywanie użytkownika o a i b:
        Console.WriteLine("Wprowadz a i b: ");
        string a = Console.ReadLine();
        string b = Console.ReadLine();

        //Konwersja stringów na liczby odbywa się za pomocą warunku
        if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b))
        {
            if(int.TryParse(a, out num1) && int.TryParse(b, out num2))
            {
                Console.Clear();
                Console.WriteLine("Wybrano: " +a+ " oraz " +b);
                Console.WriteLine("Wybierz, co chcesz zrobic: ");
                Console.WriteLine("--");
                Console.WriteLine("a) Dodawanie");
                Console.WriteLine("b) Odejmowanie");
                Console.WriteLine("c) Mnozenie");
                Console.WriteLine("d) Dzielenie");
                Console.WriteLine("--");

                // Wybór akcji
                string menu = Console.ReadLine();

                //Konwersja string do char
                try
                {
                    char opcja = char.Parse(menu);
                    Console.WriteLine("Wybrano opcje "+menu);

                    if(opcja == 'a')
                    {
                        int wynik = program.dodawanie(num1, num2);
                        Console.WriteLine("Wynik dodawania to: " +wynik);
                        Console.ReadKey();
                    }

                    if(opcja == 'b')
                    {
                        int wynik = program.odejmowanie(num1, num2);
                        Console.WriteLine("Wynik odejmowania to: " +wynik);
                        Console.ReadKey();
                    }

                    if(opcja == 'c')
                    {
                        int wynik = program.mnozenie(num1, num2);
                        Console.WriteLine("Wynik mnozenia to: " +wynik);
                        Console.ReadKey();
                    }

                    if(opcja == 'd')
                    {
                        int wynik = program.dzielenie(num1, num2);
                        Console.WriteLine("Wynik dodawania to: " +wynik);
                        Console.ReadKey();
                    }
                }

                catch
                {
                    Console.WriteLine("Nieprawidlowy znak!");
                    Console.ReadKey();
                }
            }
            else
            {   
                Console.WriteLine("Nieprawidlowa wartosc.");
                Console.ReadKey();
            }
        }

        else
            Console.WriteLine("Pozostawiles puste pole!");
    }
}