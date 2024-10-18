namespace LMIS_Dev_Branch.Models
{
    public class Course : IModel
    {
        public string CourseID { get; set; }
        public string CourseDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DurationInMonths { get; set; }


    }
}
