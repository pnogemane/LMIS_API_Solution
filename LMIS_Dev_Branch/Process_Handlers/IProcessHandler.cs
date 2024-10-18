using LMIS_Dev_Branch.Models;
using System.Collections;
namespace LMIS_Dev_Branch.Process_Handler

{
    public interface IProcessHandler
    {
        public void PerformTask();
        public List<IModel> GetModel();

    }
}
