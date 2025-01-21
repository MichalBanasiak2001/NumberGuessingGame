// Program napisany przez Michała Banasiaka

Console.WriteLine("Program autorstwa: Michała Banasiaka.");
Console.WriteLine();
Console.WriteLine("Witamy w grze na zgadywanie liczby!\n(Wylosowana liczba jest od 1 do 100). Masz możliwość dostosowania ustawień gry.");

// Wybór liczby żyć
Console.Write("Ile żyć chcesz mieć? Podaj liczbę: ");
int lives;
while (!int.TryParse(Console.ReadLine(), out lives) || lives <= 0)
{
    Console.WriteLine("Proszę podaj prawidłową liczbę większą od 0!");
}

// Wybór marginesu błędu
Console.Write("Jaki margines błędu chcesz ustawić? Podaj liczbę (0, jeśli nie chcesz marginesu): ");
int errorMargin;
while (!int.TryParse(Console.ReadLine(), out errorMargin) || errorMargin < 0)
{
    Console.WriteLine("Proszę podaj prawidłową liczbę większą lub równą 0!");
}

int randomNumber = new Random().Next(1, 101);
bool victory = false;

while (lives > 0 && !victory)
{
    Console.WriteLine($"\nPozostałe życia: {lives}");
    Console.Write("Podaj swoją liczbę: ");

    int playerNumber;
    // Obsługa błędnego wejścia
    while (!int.TryParse(Console.ReadLine(), out playerNumber))
    {
        Console.WriteLine("Proszę wpisać poprawną liczbę!");
    }

    // Sprawdzenie zwycięstwa
    if (playerNumber == randomNumber || (errorMargin > 0 && Math.Abs(playerNumber - randomNumber) <= errorMargin))
    {
        Console.WriteLine($"Wygrałeś! Gratulacje! Wylosowana liczba to: {randomNumber}");
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
    Console.WriteLine($"\nKoniec gry! Wylosowana liczba to: {randomNumber}");
}
