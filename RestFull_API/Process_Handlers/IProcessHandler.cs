using StockSense_DotNET_API.Models;
using System.Collections;
namespace StockSense_DotNET_API.Process_Handler

{
    public interface IProcessHandler
    {
        public void PerformTask();
        public List<IModel> GetModel();

    }
}
