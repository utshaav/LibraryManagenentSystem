using System.Collections.Generic;

public class Books
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    // public string CoverUrl { get; set; }
    public string Language { get; set; }
    public string Category { get; set; }
    public string ISBN { get; set; }

    public static List<Books> GetBooks()
    {
        Books b1 = new Books() { Title = "Ramro Kitab", Author = "Utsav Dada", Publisher = "XAV Pubs", Language = "Nepali", Category = "Comics", ISBN = "0123456789" };
        Books b2 = new Books() { Title = "Ramro Kitab", Author = "Utsav Dada", Publisher = "XAV Pubs", Language = "Nepali", Category = "Comics", ISBN = "0123456789" };
        return new List<Books>() { b1, b2 };

    }
}