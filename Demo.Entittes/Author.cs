using System.Collections.Generic;

namespace Demo.Entittes
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AuthorProfile AuthorProfile { get; set; }
        public List<Book> Books { get; set; }

    }


    public class AuthorProfile
    {
        public int AuthorProfileId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }


    }

}
