using StudentWebApplication.Models;

namespace StudentWebApplication.Services
{
    public interface IStudentServices
    {
        List<Student> GetAll();

        Student GetById(int id);
        bool insert(Student student);
        bool update(Student student);
        bool delete(int id);
    }
}
