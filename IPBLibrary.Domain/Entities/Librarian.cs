namespace IPBLibrary.Domain.Entities
{
    public class Librarian : Person
    {
        public string EmployeeNumber { get; set; }
        public string Password { get; set; }
        public string? Role { get; set; } // Librarian, Assistant, etc.
    }
}
