using StockSense_DotNET_API.Models;
using StockSense_DotNET_API.Process_Handler;

namespace StockSense_DotNET_API.Process_Handlers.Student_Handlers
{
    public class AddStudentHandler : IProcessHandler
    {
        private Student StudentDetails { get; set; }
        private List<IModel> ReturnModel { get; set; }

        public AddStudentHandler(Student student)
        {
            this.StudentDetails = student;
            ReturnModel = new List<IModel>();
        }

        public void PerformTask()
        {
            //Add Student Details to database using DB Context

            //Add message to list
            ReturnModel.Add(new MessagingModel("Student Successfully Added"));
        }
        public List<IModel> GetModel()
        {
            return ReturnModel;
        }
    }
}
