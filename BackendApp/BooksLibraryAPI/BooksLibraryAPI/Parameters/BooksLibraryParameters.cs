namespace BooksLibraryAPI.Parameters;

public class BooksLibraryParameters
{

    public string? Author { get; set; }
    public string? ISBN { get; set; }
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; }

}