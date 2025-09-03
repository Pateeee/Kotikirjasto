using System;

namespace KirjalistaApp
{
    class Program
    {
        static void Main()
        {
            var library = new BookLibrary();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n1) Lisää kirja");
                Console.WriteLine("2) Poista kirja");
                Console.WriteLine("3) Näytä kaikki kirjat");
                Console.WriteLine("4) Näytä kirjat genren mukaan");
                Console.WriteLine("5) Etsi kirja (nimi/kirjoittaja)");
                Console.WriteLine("0) Lopeta");
                Console.Write("");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Nimi: ");
                        var title = Console.ReadLine() ?? string.Empty;

                        Console.Write("Kirjoittaja: ");
                        var author = Console.ReadLine() ?? string.Empty;

                        Console.Write("Vuosi: ");
                        if (!int.TryParse(Console.ReadLine(), out int year))
                            year = 0;

                        Console.Write("Genre: ");
                        var genre = Console.ReadLine() ?? string.Empty;

                        library.AddBook(title, author, year, genre);
                        break;

                    case "2":
                        int i = 0;
                        foreach (var b in library.GetAllBooks())
                            Console.WriteLine($"[{i++}] {b}");

                        Console.Write("Anna poistettavan kirjan numero: ");
                        if (int.TryParse(Console.ReadLine(), out int idx))
                            library.RemoveBook(idx);
                        break;

                    case "3":
                        foreach (var b in library.GetAllBooks())
                            Console.WriteLine(b);
                        break;

                    case "4":
                        Console.Write("Genre: ");
                        var g = Console.ReadLine() ?? string.Empty;

                        foreach (var b in library.GetBooksByGenre(g))
                            Console.WriteLine(b);
                        break;

                    case "5":
                        Console.Write("Hakusana: ");
                        var q = Console.ReadLine() ?? string.Empty;

                        foreach (var b in library.SearchBooks(q))
                            Console.WriteLine(b);
                        break;

                    case "0":
                        running = false;
                        break;
                }
            }
        }
    }
}
