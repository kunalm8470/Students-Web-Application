namespace Students.Domain.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male = 0,
        Female,
        Polygender,
        Genderfluid,
        Genderqueer,
        Bigender,
        Agender,
        NonBinary
    }
}
