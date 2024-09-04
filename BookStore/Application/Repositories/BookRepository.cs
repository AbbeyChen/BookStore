using BookStore.Application.Common.Models;
using BookStore.Infrastructure.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace BookStore.Application.Repositories
{
    public class BookRepository : GenericRepository, IBookRepository
    {
        public BookRepository(IConfiguration configuration) : base(configuration)
        {
        }
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
