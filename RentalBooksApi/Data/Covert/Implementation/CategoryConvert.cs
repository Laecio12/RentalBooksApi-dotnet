using System.Collections.Generic;
using System.Linq;
using RentalBooksApi.Data.Covert.Contract;
using RentalBooksApi.Data.Vo;
using RentalBooksApi.Models;

namespace RentalBooksApi.Data.Covert.Implementation
{
    public class CategoryConvert : IParser<CategoryVo, Category>, IParser<Category, CategoryVo>
    {
        public Category Parse(CategoryVo origin)
        {
            if (origin is null) return null;
            return new Category
            {
                Id = origin.Id,
                CategoryName = origin.CategoryName
            };
        }

        public List<Category> Parse(List<CategoryVo> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public CategoryVo Parse(Category origin)
        {
            if (origin is null) return null;
            return new CategoryVo
            {
                Id = origin.Id,
                CategoryName = origin.CategoryName
            };
        }

        public List<CategoryVo> Parse(List<Category> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}