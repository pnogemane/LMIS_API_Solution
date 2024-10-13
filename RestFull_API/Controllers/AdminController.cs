using Microsoft.AspNetCore.Mvc;
using StockSense_DotNET_API.Models;
using StockSense_DotNET_API.Process_Handler;

namespace StockSense_DotNET_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    
    public class AdminController : ControllerBase
    {
 
        public IActionResult RegisterStudent(RegistrationModel registrationModel)
        {
            IProcessHandler ProcessHandler = new RegistrationHandler(registrationModel);
            ProcessHandler.PerformTask();
            return Ok(ProcessHandler.GetModel());
        }
    }
}
