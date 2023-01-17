using Microsoft.OpenApi.Writers;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BooksLibraryAPI.Models
{
    public class Books
    {
        [Key]
        public int Book_Id { get; set; }
        public string Title { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Total_Copies { get; set; }
        public int Copies_In_Use{get;set;}
        public string Type { get; set; }
        public string ISBN { get; set; }

        public string Category { get; set; }

    }
}
