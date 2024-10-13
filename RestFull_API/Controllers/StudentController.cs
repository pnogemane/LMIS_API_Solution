using Microsoft.AspNetCore.Mvc;
using StockSense_DotNET_API.Models;
using StockSense_DotNET_API.Process_Handler;
using StockSense_DotNET_API.Process_Handlers.Student_Handlers;

namespace StockSense_DotNET_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        [HttpGet]
        [Route("getAllStudents")]
        public IActionResult  GetAllStudents()
        {
            IProcessHandler ProcessHandler = new GetAllStudentsHandler();
            ProcessHandler.PerformTask();
            return Ok(ProcessHandler.GetModel());
        }

        [HttpPost]
        [Route("AddStudent")]
        public IActionResult AddStudent(Student student)
        {
            IProcessHandler ProcessHandler = new AddStudentHandler(student);
            ProcessHandler.PerformTask();
            return Ok(ProcessHandler.GetModel());
        }
    }
}
