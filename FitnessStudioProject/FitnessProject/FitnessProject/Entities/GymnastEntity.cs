namespace FitnessProject.Entities
{
    [Flags]
    public enum CourseType { BALLET = 0, FLOOR = 1, AEROBICS = 2,BAYLLA = 4, ZOMBA = 8, HIPHOP = 16, DANCE = 32  }

    public class GymnastEntity
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public CourseType Course { get; set; }

        public GymnastEntity()
        {
            
        }

        public GymnastEntity(string id, string firstName, string lastName, DateOnly dateOfBirth,
            string phoneNumber, string email, Address address, CourseType course)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            Course = course;
        }
    }
}
