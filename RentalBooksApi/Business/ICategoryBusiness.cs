using System.Collections.Generic;
using RentalBooksApi.Data.Vo;

namespace RentalBooksApi.Business
{
    public interface ICategoryBusiness
    {
        CategoryVo Create(CategoryVo category);
        CategoryVo FindById(long id);
        List<CategoryVo> FindAll();
        CategoryVo Update(CategoryVo category);
        void Delete(long id);
    }
}