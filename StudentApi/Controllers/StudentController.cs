using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentApi.Models;
using StudentApi.Repository;
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


        [HttpGet]
        [Route("/students/{id}")]
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
        [Route("/students")]
        public IActionResult CreateStudent(Student student)
        {
            _studentRepository.CreateStudent(student);

            return CreatedAtRoute(null, null);


        }

        [HttpPut]
        [Route("/students/{id}")]

        public IActionResult UpdateStudent(int id, Student student)
        {
            var _student = _studentRepository.getStudentById(id);

            if (_student == null)
            {
                return NotFound();
            }

            _studentRepository.UpdateStudent(student);

            return NoContent();
        }



        [HttpDelete]
        [Route("/students/{id}")]

        public IActionResult DeleteStudent(int id, Student student)
        {
            var _student = _studentRepository.getStudentById(id);

            if (_student == null)
            {
                return NotFound();
            }

            _studentRepository.DeleteStudent(id);

            return StatusCode(StatusCodes.Status410Gone);
        }
    }
}


