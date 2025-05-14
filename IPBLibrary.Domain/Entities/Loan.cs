namespace IPBLibrary.Domain.Entities
{
    public class Loan
    {
        public int Id { get; set; }
        public Member Member { get; set; }
        public Book Book { get; set; }
        public Librarian Librarian { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool IsReturned { get; set; }
    }
}
