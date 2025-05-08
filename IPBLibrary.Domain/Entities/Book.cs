namespace IPBLibrary.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public Author Author{ get; set; }
        public Category Category { get; set; }
        public Publisher Publisher { get; set; }   
        public string? ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Genre { get; set; }
    }
}
