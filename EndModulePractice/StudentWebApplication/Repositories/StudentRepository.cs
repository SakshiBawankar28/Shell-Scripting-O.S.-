using StudentWebApplication.Models;
using System.Linq;

namespace StudentWebApplication.Repositories
{
    public class StudentRepository 
    {
        public static List<Student> GetAll()
        {
            using(var context = new CollectionContext())
            {
                var students = from student in context.student select student;
                return students.ToList<Student>();
            }
        }

        public static bool insert(Student student)
        {
            using(var context = new CollectionContext())
            {
                context.student.Add(student);
                context.SaveChanges();
            }
            return true;
        }
        public static Student GetById(int id)
        {
            using(var context = new CollectionContext())
            {
                return context.student.Find(id);
            }
        }
        public static bool update(Student student)
        {
            using( var context = new CollectionContext())
            {
                var stu = context.student.Find(student.id);
                stu.name = student.name;
                stu.email = student.email;
                stu.mobileno = student.mobileno;
                stu.address = student.address;
                stu.admission_date = student.admission_date;
                stu.fees = student.fees;
                stu.status = student.status;
                context.SaveChanges();
            }
            return true;
        }
        public static bool delete(int id)
        {
            using(var context = new CollectionContext())
            {
                context.student.Remove(context.student.Find(id));
                context.SaveChanges();
            }
            return true;
        }
    }
}
