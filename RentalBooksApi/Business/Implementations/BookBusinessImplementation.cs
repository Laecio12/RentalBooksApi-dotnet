using System.Collections.Generic;
using RentalBooksApi.Data.Covert.Implementation;
using RentalBooksApi.Data.Vo;
using RentalBooksApi.Models;
using RentalBooksApi.Repository.Generic;

namespace RentalBooksApi.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IRepository<Book> _repository;
        private readonly BookConvert _convert;

        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _convert = new BookConvert();
        }
        public BookVo Create(BookVo book)
        {
            var bookEntity = _convert.Parse(book);
            bookEntity = _repository.Create(bookEntity);
            return _convert.Parse(bookEntity);
        }

        public BookVo FindById(long id)
        {
            return _convert.Parse(_repository.FindById(id));
        }

        public List<BookVo> FindAll()
        {
            return _convert.Parse(_repository.FindAll());
        }

        public BookVo Update(BookVo book)
        {
            var bookEntity = _convert.Parse(book);
            bookEntity = _repository.Create(bookEntity);
            return _convert.Parse(bookEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}