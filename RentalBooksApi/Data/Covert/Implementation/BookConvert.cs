using System.Collections.Generic;
using System.Linq;
using RentalBooksApi.Data.Covert.Contract;
using RentalBooksApi.Data.Vo;
using RentalBooksApi.Models;

namespace RentalBooksApi.Data.Covert.Implementation
{
    public class BookConvert : IParser<BookVo, Book>, IParser<Book, BookVo>

    {
        public Book Parse(BookVo origin)
        {
            if (origin == null) return null;
            return new Book
            {
                Id = origin.Id,
                Author = origin.Author,
                LaunchDate = origin.LaunchDate,
                Price = origin.Price,
                Title = origin.Title,
                CategoryId = origin.CategoryId
            };
        }

        public BookVo Parse(Book origin)
        {
            if (origin == null) return null;
            return new BookVo 
            {
                Id = origin.Id,
                Author = origin.Author,
                LaunchDate = origin.LaunchDate,
                Price = origin.Price,
                Title = origin.Title,
                CategoryId = origin.CategoryId
            };
        }

        public List<Book> Parse(List<BookVo> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<BookVo> Parse(List<Book> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}