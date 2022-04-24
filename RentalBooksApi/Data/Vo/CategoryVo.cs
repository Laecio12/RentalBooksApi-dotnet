using System.Collections.Generic;
using RentalBooksApi.Models;

namespace RentalBooksApi.Data.Vo
{
    public class CategoryVo
    {
        public long Id { get; set; }
        
        public string CategoryName { get; set; }

        private ICollection<Book> Books { get; set; }
    }
}