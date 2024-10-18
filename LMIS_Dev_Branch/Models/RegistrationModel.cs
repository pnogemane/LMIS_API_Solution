namespace LMIS_Dev_Branch.Models
{
    public class RegistrationModel : IModel
    {
        public Student StudentDetails { get; set; }
        public Course CourseDetails { get; set; }
        public RegistrationModel(Student studentdetails,Course coursedetails)
        {
            this.StudentDetails = studentdetails;
            this.CourseDetails = coursedetails;
        }

    }
}
