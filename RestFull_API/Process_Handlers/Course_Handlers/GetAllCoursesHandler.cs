using StockSense_DotNET_API.Models;

namespace StockSense_DotNET_API.Process_Handler.Course_Handlers
{
    public class GetAllCoursesHandler : IProcessHandler
    {
        public List<Course> Courses { get; set; }
        public List<IModel> ReturnModel { get; set; }

        public  GetAllCoursesHandler()
        {
            ReturnModel = new List<IModel>();
        }

        public void PerformTask()
        {
            //Get Courses from databases using DB Context
            //Perform Iteration here
            //Populate the content from db onto object collection
        }
        public List<IModel> GetModel()
        {
            return ReturnModel;
        }
    }
}
