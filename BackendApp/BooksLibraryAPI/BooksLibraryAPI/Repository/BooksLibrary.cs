using BooksLibraryAPI.Models;
using BooksLibraryAPI.Parameters;
using BooksLibraryAPI.Persistences;

namespace BooksLibraryAPI.Repository
{
   
    public class BooksLibrary : IBooksLibrary
    {
        private readonly DataContext _dataContext;
        public BooksLibrary(DataContext dataContext) 
        {
            _dataContext = dataContext;
        }
        public IList<Books> GetAllBooks()
        {
            return _dataContext.Books.ToList();
        }

        public IList<Books> GetBooksFilters(BooksLibraryParameters parameters)
        {
            var queryResult = _dataContext.Books.ToList();

            if (!string.IsNullOrEmpty(parameters.Author))
            {
                queryResult = queryResult.Where(x => (x.First_Name.Trim() + " " + x.Last_Name.Trim()).Trim().Contains(parameters.Author)).ToList();
            }

            if (!string.IsNullOrEmpty(parameters.ISBN))
            {
                queryResult = queryResult.Where(s => s.ISBN.Contains(parameters.ISBN)).ToList();
            }
            if (parameters.PageSize == 0)
            {
                return queryResult.ToList();
            }

            return queryResult.Skip((parameters.PageNumber - 1) * parameters.PageSize)
                   .Take(parameters.PageSize)
                   .ToList();

            
        }
    }
}
