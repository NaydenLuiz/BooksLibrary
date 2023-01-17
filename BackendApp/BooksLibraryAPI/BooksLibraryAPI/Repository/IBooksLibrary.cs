

using BooksLibraryAPI.Models;
using BooksLibraryAPI.Parameters;

namespace BooksLibraryAPI.Repository;

    public interface IBooksLibrary
    {
        IList<Books> GetAllBooks();
        IList<Books> GetBooksFilters(BooksLibraryParameters parameters);
    }

