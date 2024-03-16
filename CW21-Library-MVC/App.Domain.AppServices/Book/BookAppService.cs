using App.Domain.Core.Book.AppServices;
using App.Domain.Core.Book.DTOs;
using App.Domain.Core.Book.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Book
{
    public class BookAppService : IBookAppService
    {
        private readonly IBookService _bookService;

        public BookAppService(IBookService bookService)
        {
            _bookService = bookService;
        }

        public void BorrowBook(int booDtoId, int userDtoId)
        {
            throw new NotImplementedException();
        }

        public void CreateBook(BookDto bookDto)
        {
            throw new NotImplementedException();
        }

        public BookDto GetBookByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public BookDto GetBookById(int bookId)
        {
            throw new NotImplementedException();
        }

        public List<BookDto> GetBooks()
        {
            throw new NotImplementedException();
        }

        public void HardDeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public void ReturnBook(int bookDtoId, int userDtoId)
        {
            throw new NotImplementedException();
        }

        public void SoftDeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(BookDto updatedBookDto)
        {
            throw new NotImplementedException();
        }
    }
}
