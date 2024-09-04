using BookStore.Application.Common.Interfaces;
using BookStore.Application.Common.Models;
using BookStore.Infrastructure.Interfaces;

namespace BookStore.Application.Services
{
    public class BookService(IBookRepository bookRepository) : IBookService
    {
        public readonly IBookRepository _bookRepository = bookRepository;

        public async Task<BookDto> GetBook(int bookId)
        {
            return new BookDto();
        }
        public async Task<List<BookDto>> GetBooks(List<int> bookIds)
        {
            return new List<BookDto>();
        }

        public async Task AddBooks(List<BookDto> bookDto)
        {
        }

        public async Task UpdateBooks(List<BookDto> bookDto)
        {
        }

        public async Task DeleteBooks(List<BookDto> bookDto)
        {
        }
    }
}
