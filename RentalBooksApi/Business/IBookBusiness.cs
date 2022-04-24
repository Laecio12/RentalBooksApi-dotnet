using System.Collections.Generic;
using RentalBooksApi.Data.Vo;

namespace RentalBooksApi.Business
{
    public interface IBookBusiness
    {
        BookVo Create(BookVo book);
        BookVo FindById(long id);
        List<BookVo> FindAll();
        BookVo Update(BookVo book);
        void Delete(long id);
    }
}