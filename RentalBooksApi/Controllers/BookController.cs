using Microsoft.AspNetCore.Mvc;
using RentalBooksApi.Business;
using RentalBooksApi.Data.Vo;

namespace RentalBooksApi.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookBusiness _bookBusiness;

        public BookController(IBookBusiness bookBusiness)
        {
            _bookBusiness = bookBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bookBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var book = _bookBusiness.FindById(id);
            if (book is null) return NotFound("Livro não encontrado");
            return Ok(book);

        }

        [HttpPost]
        public IActionResult Post([FromBody] BookVo book)
        {
            if (book is null) return BadRequest("Digite os dados do livro");
            _bookBusiness.Create(book);
            return Ok();
        }
        
        [HttpPut]
        public IActionResult Put(BookVo book)
        {
            if (book is null) return BadRequest("Digite os dados do livro");
            return Ok(_bookBusiness.Update(book));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var book = _bookBusiness.FindById(id);
            if (book is null) return BadRequest("Book not found");
            _bookBusiness.Delete(id);
            return NoContent();
        }
    }
}