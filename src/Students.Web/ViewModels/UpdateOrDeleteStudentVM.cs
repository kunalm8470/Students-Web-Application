using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Students.Web.ViewModels
{
    public class UpdateOrDeleteStudentVM
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        [Required]
        [StringLength(200, ErrorMessage = "First name cannot be more than 100 characters")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        [StringLength(200, ErrorMessage = "Last name cannot be more than 100 characters")]
        public string LastName { get; set; }

        [DisplayName("Date of Birth")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DateOfBirth { get; set; } = default;

        [DisplayName("Gender")]
        [Required]
        public string Gender { get; set; }

        public List<SelectListItem> Genders { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = default, Text = "---PLEASE SELECT---", Disabled = true, Selected = true },
            new SelectListItem { Value = "Male", Text = "Male" },
            new SelectListItem { Value = "Female", Text = "Female" },
            new SelectListItem { Value = "Polygender", Text = "Polygender" },
            new SelectListItem { Value = "Genderfluid", Text = "Genderfluid" },
            new SelectListItem { Value = "Genderqueer", Text = "Genderqueer" },
            new SelectListItem { Value = "Bigender", Text = "Bigender" },
            new SelectListItem { Value = "Agender", Text = "Agender" },
            new SelectListItem { Value = "NonBinary", Text = "Non Binary" }
        };
    }
}
