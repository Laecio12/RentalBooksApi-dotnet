using System.Collections.Generic;
using RentalBooksApi.Data.Covert.Implementation;
using RentalBooksApi.Data.Vo;
using RentalBooksApi.Models;
using RentalBooksApi.Repository.Generic;

namespace RentalBooksApi.Business.Implementations
{
    public class CategoryBusinessImplementation : ICategoryBusiness
    {
        private readonly IRepository<Category> _repository;
        private readonly CategoryConvert _convert;

        public CategoryBusinessImplementation(IRepository<Category> repository, CategoryConvert convert)
        {
            _repository = repository;
            _convert = convert;
        }

        public CategoryVo Create(CategoryVo category)
        {
            var categoryEntity = _convert.Parse(category);
            categoryEntity = _repository.Create(categoryEntity);
            return _convert.Parse(categoryEntity);
        }

        public CategoryVo FindById(long id)
        {
            return _convert.Parse(_repository.FindById(id));
        }

        public List<CategoryVo> FindAll()
        {
            return _convert.Parse(_repository.FindAll());
        }

        public CategoryVo Update(CategoryVo category)
        {
            var categoryEntity = _convert.Parse(category);
            categoryEntity = _repository.Create(categoryEntity);
            return _convert.Parse(categoryEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}