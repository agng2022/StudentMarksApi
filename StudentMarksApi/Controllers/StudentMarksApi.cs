using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StudentMarksApi.Models;
using System.Collections.Generic;

namespace StudentMarksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public StudentController(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        [HttpGet("GetStudents")]
        public IActionResult GetStudents()
        {
            var students = new List<Student>
            {
                new Student { Id = 1, Name = "John Doe", SubjectMarks = new Dictionary<string, int> { { "Math", 85 }, { "Science", 90 } } },
                new Student { Id = 2, Name = "Jane Smith", SubjectMarks = new Dictionary<string, int> { { "Math", 78 }, { "Science", 88 } } }
            };

            return Ok(students);
        }

        [HttpGet("GetConfig")]
        public IActionResult GetConfig()
        {
            var configData = new
            {
                Environment = _configuration["Environment"],
                ApplicationName = _configuration["ApplicationName"],
                Version = _configuration["Version"]
            };

            return Ok(configData);
        }
    }
}
