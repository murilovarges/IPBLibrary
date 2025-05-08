namespace IPBLibrary.Domain.Entities
{
    public class Fine
    {
        public int Id { get; set; }
        public Member Member { get; set; }
        public decimal Amount { get; set; }
        public DateTime IssuedDate { get; set; }
        public bool IsPaid { get; set; }
    }
}
