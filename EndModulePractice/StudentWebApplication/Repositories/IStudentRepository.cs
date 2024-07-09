using StudentWebApplication.Models;

namespace StudentWebApplication.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        bool insert(Student student);
        Student GetById(int id);
        bool update(Student student);
        bool delete(int id);
    }
}
