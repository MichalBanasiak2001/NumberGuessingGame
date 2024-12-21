//Program napisany przez Michała Banasiaka

Console.WriteLine("Program autorstwa: Michała Banasiaka 2024");
Console.WriteLine();
Console.WriteLine("Witamy w grze na zgadywanie liczby! Podaj swoją liczbę:");
Console.WriteLine("(Wylosowana liczba jest od 1 do 100).");

int liczba = Convert.ToInt32(Console.ReadLine());
int losowa = new Random().Next(1, 101);

if (liczba == losowa)
{
    Console.WriteLine("Wygrałes!");
}
else
{
    Console.WriteLine("Przegrałes!");
    if (liczba > losowa)
    {
        Console.WriteLine("Wylosowana liczba jest mniejsza od twojej o: " + (liczba - losowa));
    }
    else if (liczba < losowa)
    {    
        Console.WriteLine("Wylosowana liczba jest większa od twojej o: " + (losowa - liczba));
    }

}