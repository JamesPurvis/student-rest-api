using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentApi.Models;
using StudentApi.Repository.Interfaces;

namespace StudentApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }


        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = _studentRepository.getStudentById(id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }


        [HttpPost]
        [Route("/create")]
        public IActionResult CreateStudent(Student student)
        {
            _studentRepository.CreateStudent(student);

            return CreatedAtRoute(null, null);


        }
    }
}

