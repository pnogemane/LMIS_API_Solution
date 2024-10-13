using StockSense_DotNET_API.Models;

namespace StockSense_DotNET_API.Process_Handler.Course_Handlers
{
    public class CreateCourseHandler : IProcessHandler
    {
        private Course CourseDetails { get; set; }
        private List <IModel>ReturnModel { get; set; }

        public CreateCourseHandler(Course course)
        {
            this.CourseDetails = course;
            ReturnModel = new List<IModel>();
        }

        public void PerformTask()
        {
            //Add Course Details to database using DB Context

            //Add message to list
            ReturnModel.Add(new MessagingModel("Course Successfully Created"));
        }
        public List<IModel> GetModel()
        { 
            return ReturnModel;
        }
    }
}
