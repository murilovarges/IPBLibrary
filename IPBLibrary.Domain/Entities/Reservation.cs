namespace IPBLibrary.Domain.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public Member Member { get; set; }
        public Book Book { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
