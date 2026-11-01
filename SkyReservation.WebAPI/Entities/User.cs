namespace SkyReservation.WebAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string LatinFirstName { get; set; }
        //public string LatinLastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool EmailConfirmed { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
