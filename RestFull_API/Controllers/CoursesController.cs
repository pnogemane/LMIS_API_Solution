using Microsoft.AspNetCore.Mvc;
using StockSense_DotNET_API.Models;
using StockSense_DotNET_API.Process_Handler;
using StockSense_DotNET_API.Process_Handler.Course_Handlers;

namespace StockSense_DotNET_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {

        [HttpGet]
        [Route("getAllCourses")]
        public IActionResult getAllCourses()
        {

            IProcessHandler ProcessHandler = new GetAllCoursesHandler();
            ProcessHandler.PerformTask();
            return Ok(ProcessHandler.GetModel());
        }

        [HttpGet]
        [Route("getCourseByCourseID")]
        public IActionResult getCourseByCourseID(string courseID)
        {
            IProcessHandler ProcessHandler = new GetCourseByIdHandler(courseID);
            ProcessHandler.PerformTask();
            return Ok(ProcessHandler.GetModel());   
        }

        [HttpPost]
        [Route("createCourse")]

        public IActionResult CreateCourse(Course course)
        {
            IProcessHandler ProcessHandler = new CreateCourseHandler(course);
            ProcessHandler.PerformTask();
            return Ok(ProcessHandler.GetModel());

        }
    }
}
