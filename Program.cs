// Program napisany przez Michała Banasiaka

Console.WriteLine("Program autorstwa: Michała Banasiaka 2024");
Console.WriteLine();
Console.WriteLine("Witamy w grze na zgadywanie liczby!\n(Wylosowana liczba jest od 1 do 100). Masz 3 życia. Powodzenia!");

int losowa = new Random().Next(1, 101);
int lifes = 3;
bool wygrana = false;

while (lifes > 0 && !wygrana)
{
    Console.WriteLine($"\nPozostałe życia: {lifes}");
    Console.Write("Podaj swoją liczbę: ");

    int liczba;
    // Obsługa błędnego wejścia
    while (!int.TryParse(Console.ReadLine(), out liczba))
    {
        Console.WriteLine("Proszę wpisać poprawną liczbę!");
    }

    if (liczba == losowa)
    {
        Console.WriteLine("Wygrałeś! Gratulacje!");
        wygrana = true;
    }
    else
    {
        lifes--;
        Console.WriteLine("Przegrałeś!");

        if (liczba > losowa)
        {
            Console.WriteLine($"Wylosowana liczba jest mniejsza od twojej.");
        }
        else
        {
            Console.WriteLine($"Wylosowana liczba jest większa od twojej.");
        }

        if (lifes > 0)
        {
            Console.WriteLine("Spróbuj ponownie.");
        }
    }
}

if (!wygrana)
{
    Console.WriteLine($"\nKoniec gry! Wylosowana liczba to: {losowa}");
}
