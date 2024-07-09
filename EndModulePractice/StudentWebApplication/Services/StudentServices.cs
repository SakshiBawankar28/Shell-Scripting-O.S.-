using StudentWebApplication.Models;
using StudentWebApplication.Repositories;

namespace StudentWebApplication.Services
{
    public class StudentServices : IStudentServices
    {
        public List<Student> GetAll()
        {
            return StudentRepository.GetAll();
        }

        public bool insert(Student student)
        {
            return StudentRepository.insert(student);
        }

        public bool update(Student student)
        {
            return StudentRepository.update(student);
        }

        bool IStudentServices.delete(int id)
        {
            return StudentRepository.delete(id);
        }

        Student IStudentServices.GetById(int id)
        {
            return StudentRepository.GetById(id);
        }
    }
}
