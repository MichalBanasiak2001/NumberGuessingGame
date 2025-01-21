// Program napisany przez Michała Banasiaka

Console.WriteLine("Program autorstwa: Michała Banasiaka 2024");
Console.WriteLine();
Console.WriteLine("Witamy w grze na zgadywanie liczby!\n(Wylosowana liczba jest od 1 do 100). Masz możliwość dostosowania ustawień gry.");

// Wybór liczby żyć
Console.Write("Ile żyć chcesz mieć? Podaj liczbę: ");
int lives;
while (!int.TryParse(Console.ReadLine(), out lives) || lives <= 0)
{
    Console.WriteLine("Proszę podaj prawidłową liczbę większą od 0!");
}

// Wybór opcji zakresu błędu
Console.Write("Czy chcesz włączyć zakres błędu o 5? (tak/nie): ");
bool errorMargin = Console.ReadLine().Trim().ToLower() == "tak";

int randomNumber = new Random().Next(1, 101);
bool victory = false;

while (lives > 0 && !victory)
{
    Console.WriteLine("\nPozostałe życia: " + lives);
    Console.Write("Podaj swoją liczbę: ");

    int playerNumber;
    // Margines błędu
    while (!int.TryParse(Console.ReadLine(), out playerNumber))
    {
        Console.WriteLine("Proszę wpisać poprawną liczbę!");
    }

    // Sprawdzanie zwycięstwa
    if (playerNumber == randomNumber || (errorMargin && Math.Abs(playerNumber - randomNumber) <= 5))
    {
        Console.WriteLine("Wygrałeś! Gratulacje! Wylosowana liczba to: " + randomNumber);
        victory = true;
    }
    else
    {
        lives--;
        Console.WriteLine("Przegrałeś!");

        if (playerNumber > randomNumber)
        {
            Console.WriteLine($"Wylosowana liczba jest mniejsza od twojej.");
        }
        else
        {
            Console.WriteLine($"Wylosowana liczba jest większa od twojej.");
        }

        if (lives > 0)
        {
            Console.WriteLine("Spróbuj ponownie.");
        }
    }
}

if (!victory)
{
    Console.WriteLine("\nKoniec gry! Wylosowana liczba to: " + randomNumber);
}
