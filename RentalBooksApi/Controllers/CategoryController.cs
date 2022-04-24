using Microsoft.AspNetCore.Mvc;
using RentalBooksApi.Business;
using RentalBooksApi.Data.Vo;

namespace RentalBooksApi.Controllers
{
    [ApiController]
    [Route("api[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryBusiness _categoryBusiness;

        public CategoryController(ICategoryBusiness business)
        {
            _categoryBusiness = business;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_categoryBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var categoria = _categoryBusiness.FindById(id);
            if (categoria is null) return NotFound("Categoria não encontrado");
            return Ok(categoria);

        }

        [HttpPost]
        public IActionResult Post([FromBody] CategoryVo categoria)
        {
            if (categoria is null) return BadRequest("Digite os dados da categoria");
            _categoryBusiness.Create(categoria);
            return Ok();
        }
        
        [HttpPut]
        public IActionResult Put(CategoryVo categoria)
        {
            if (categoria is null) return BadRequest("Digite os dados da categoria");
            return Ok(_categoryBusiness.Update(categoria));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var book = _categoryBusiness.FindById(id);
            if (book is null) return BadRequest("Categoria não encontrada");
            _categoryBusiness.Delete(id);
            return NoContent();
        }
        
        
    }
}