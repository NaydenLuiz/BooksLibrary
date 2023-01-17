using BooksLibraryAPI.Models;
using BooksLibraryAPI.Parameters;
using BooksLibraryAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BooksLibraryAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksLibraryController : ControllerBase
    {
        private readonly IBooksLibrary _booksRepository;
        public BooksLibraryController(IBooksLibrary booksRepository)
        {
            _booksRepository = booksRepository;
        }

        //[HttpGet()]
        //public IEnumerable<Books> Get()
        //{
        //    return _booksRepository.GetAllBooks();
        //}
        [HttpGet()]
        public IEnumerable<Books> Get([FromQuery] BooksLibraryParameters parameters)
        {
            return _booksRepository.GetBooksFilters(parameters);
        }
    }
}

