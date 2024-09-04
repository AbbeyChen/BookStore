using BookStore.Application.Common.Interfaces;
using BookStore.Application.Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Web.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController(IBookService bookService) : ControllerBase
    {
        public readonly IBookService _bookService = bookService;

        [HttpGet]
        public async Task<IActionResult> GetBook(int bookId)
        {
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks(List<int> bookIds)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddBooks(List<BookDto> bookDto)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBooks(List<BookDto> bookDto)
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBooks(List<BookDto> bookDto)
        {
            return Ok();
        }
    }
}
