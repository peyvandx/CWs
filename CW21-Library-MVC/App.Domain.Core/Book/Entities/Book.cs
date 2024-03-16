namespace App.Domain.Core.Book.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsBorrowed { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int UserId { get; set; }
        public User.Entities.User User { get; set; }
        public int LibrarianId { get; set; }
        public Librarian.Entities.Librarian Librarian { get; set; }
    }
}
