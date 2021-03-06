using System;

namespace RentalBooksApi.Data.Vo
{
    public class BookVo
    {
        
        public long Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public decimal Price { get; set; }

        public DateTime LaunchDate { get; set; }
        
        public int CategoryId { get; set; }
        
    }
}