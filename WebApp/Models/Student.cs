using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [Display(Name = "Prenume")]
        public string FirstName { get; set; }
        [Display(Name = "Nume")]
        public string LastName { get; set; }
        [Display(Name = "Gen")]
        public string Gender { get; set; }
        [Display(Name = "Data nasterii")]
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        [Display(Name = "Telefon")]
        public string Phone { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

    }
}
