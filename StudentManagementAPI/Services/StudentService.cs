using StudentManagementAPI.Models;
using StudentManagementAPI.Repositories;

namespace StudentManagementAPI.Services
{
    public class StudentService
    {
        private readonly StudentRepository _repo;

        public StudentService(StudentRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Student>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Student> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task Add(Student student)
        {
            await _repo.Add(student);
        }

        public async Task Update(Student student)
        {
            await _repo.Update(student);
        }

        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }
    }
}