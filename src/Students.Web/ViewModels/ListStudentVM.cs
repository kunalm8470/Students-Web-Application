using System.ComponentModel;

namespace Students.Web.ViewModels
{
    public class ListStudentVM
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Date of Birth")]
        public string DateOfBirth { get; set; }

        [DisplayName("Gender")]
        public string Gender { get; set; }
    }
}
