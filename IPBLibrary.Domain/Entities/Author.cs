namespace IPBLibrary.Domain.Entities
{
    public class Author : Person
    {
        public string Biography { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
