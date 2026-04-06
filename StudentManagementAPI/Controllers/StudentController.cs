using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using StudentManagementAPI.Models;
using StudentManagementAPI.Services;

namespace StudentManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] 
    public class StudentController : ControllerBase
    {
        private readonly StudentService _service;

        public StudentController(StudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }

       
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _service.GetById(id);
            if (data == null)
                return NotFound("Student not found");

            return Ok(data);
        }

      
        [HttpPost]
        public async Task<IActionResult> Add(Student student)
        {
            await _service.Add(student);
            return Ok("Student Added Successfully");
        }

      
        [HttpPut]
        public async Task<IActionResult> Update(Student student)
        {
            await _service.Update(student);
            return Ok("Student Updated Successfully");
        }

       
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return Ok("Student Deleted Successfully");
        }
    }
}