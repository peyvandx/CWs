using App.Domain.Core.Book.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookDto = App.Domain.Core.Book.DTOs;

namespace App.Domain.Core.Book.Data
{
    public interface IBookRepository
    {
        public void CreateBook(BookDto.BookDto bookDto);
        public List<BookDto.BookDto> GetBooks();
        public BookDto.BookDto GetBookById(int bookId);
        public BookDto.BookDto GetBookByCategoryId(int categoryId);
        public void UpdateBook(BookDto.BookDto updatedBookDto);
        public void SoftDeleteBook(int id);
        public void HardDeleteBook(int id);
        public void BorrowBook(int booDtoId, int userDtoId);
        public void ReturnBook(int bookDtoId, int userDtoId);
    }
}
