using App.Domain.Core.Book.Data;
using App.Domain.Core.Book.DTOs;

namespace App.Infra.Data.Repos.Ef.Book
{
    public class BookRepository : IBookRepository
    {
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
