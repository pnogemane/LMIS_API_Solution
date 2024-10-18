using LMIS_Dev_Branch.Models;

namespace LMIS_Dev_Branch.Process_Handler.Course_Handlers
{
    public class GetCourseByIdHandler : IProcessHandler
    {
        private List<Course> CourseDetails { get; set; }
        private List<IModel> ReturnModel { get; set; }
        private string CourseID { get; set; }

      
        public GetCourseByIdHandler(string courseID)
        {
            this.CourseID = courseID;
            this.ReturnModel = new List<IModel>();
        }
        public void PerformTask()
        {

            //Get Course from databases using DB Context
            //Perform Iteration here
            //Populate the content from db onto object collection


            CourseDetails = new List<Course>();
            foreach (Course model in CourseDetails)
            {
                ReturnModel.Add(model);
            }
        }
        public List<IModel> GetModel()
        { 
            return ReturnModel;
        }
    }
}
