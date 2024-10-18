using LMIS_Dev_Branch.Models;

namespace LMIS_Dev_Branch.Process_Handler
{
    public class RegistrationHandler : IProcessHandler
    {
        private RegistrationModel RegistrationModel { get; set; }
        private List<IModel> ReturnModel { get; set; }
        public RegistrationHandler(RegistrationModel registrationModel)
        {
            RegistrationModel = registrationModel;
        }
        public void PerformTask()
        {
            //Perform registration
            // Pass recived data to DBContext class
            // The DBContext will add the data to the database

            ReturnModel.Add(new MessagingModel("Student Successfully Registred"));
        }

        public List<IModel> GetModel()
        {
            return ReturnModel;
        }



    }
}
