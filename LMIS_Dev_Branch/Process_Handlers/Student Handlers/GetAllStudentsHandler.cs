using LMIS_Dev_Branch.Models;
using LMIS_Dev_Branch.Process_Handler;

namespace LMIS_Dev_Branch.Process_Handlers.Student_Handlers
{
    public class GetAllStudentsHandler : IProcessHandler
    {
        private List<IModel> ReturnModel { get; set; }

        public GetAllStudentsHandler()
        {
            ReturnModel = new List<IModel>();
        }


        public void PerformTask() 
        {
            // Get Student from database from databases using DB Context
            //Perform Iteration here
            //Populate the content from db onto object collection
        }
        public List<IModel> GetModel() 
        {
            return ReturnModel;
        }
    }
}
