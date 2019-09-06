using System.Collections.Generic;
using System;

namespace BookManager.Domain.Models {
    public class Book {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public int Pages { get; set; }
        public string Description { get; set; }
        public string Synopsis { get; set; }
        public string ImageUrl { get; set; }
        public string BuyLink { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int PublishingCompanyId { get; set; }
        public PublishingCompany PublishingCompany { get; set; }

        public IEnumerable<BookGenre> BookGenres { get; set; }

    }
}