namespace KirjalistaApp
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }

        public Book(string title, string author, int year, string genre)
        {
            Title = title;
            Author = author;
            Year = year;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"{Title} — {Author} ({Year}), genre: {Genre}";
        }
    }
}
