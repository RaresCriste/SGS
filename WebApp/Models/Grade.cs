using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Grade
    {
        public int GradeID { get; set; }
        [Display(Name = "Nota")]
        public int GradeValue { get; set; }
        [Display(Name = "Data")]
        public DateTime DateOfGrading { get; set; }
        public int? EnrollmentID { get; set; }
        public Enrollment? Enrollment { get; set; }
    }
}
