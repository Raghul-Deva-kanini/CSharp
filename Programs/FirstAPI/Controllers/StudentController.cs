﻿using FirstAPI.models;
using FirstAPI.Services.StudentService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace FirstAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudentDetails()
        { 
            return _studentService.GetAllStudentDetails();
        }

        
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Student>> GetAllStudentDetailById(int id)
        {
           var student =  _studentService.GetAllStudentDetailById(id);
           if (student is null)
            {
                return NotFound("Studid not matching");
            }
           return Ok(student);
        }
        
        [HttpPost] // For Insert
        public async Task<ActionResult<List<Student>>>AddStudentDetail(Student stud)
        {
            var students = _studentService.AddStudentDetail(stud);
            return Ok(students);
        }


        [HttpPut("{id}")] // For Update
        public async Task<ActionResult<List<Student>>> UpdateStudentDetailById(int id, Student stud)
        {
            var students = _studentService.UpdateStudentDetailById(id, stud);
            if (students is null)
            {
                return NotFound("Student Id not matching");
            }
            return Ok(students);
        }

        [HttpDelete("{id}")] // For Update
        public async Task<ActionResult<List<Student>>> DeleteStudentDetailById(int id)
        {
            var students = _studentService.DeleteStudentDetailById(id);
            if (students is null)
            {
                return NotFound("Student Id not matching");
            }
            return Ok(students);
        }
        

        /*[HttpDelete]
        public async Task<ActionResult> DeleteAllStudentDetails()
        {
            foreach (var student in studentsList)
                studentsList.Remove(student);
            return Ok();
        }*/
    }
}
