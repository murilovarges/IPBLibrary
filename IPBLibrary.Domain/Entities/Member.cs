namespace IPBLibrary.Domain.Entities
{ 
    public class Member : Person
    {  
        public DateTime MembershipStartDate { get; set; }
        public DateTime? MembershipEndDate { get; set; }
        public string? Role { get; set; } // Student, Teacher, etc.
    }
}
