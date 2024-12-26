using GenericRepository.Entities;

namespace GenericRepository.Services;
public interface IStudentService
{
    List<Student> GetAllStudents();
    Student GetStudentByID(int id);
}
public class StudentService : IStudentService
{
    List<Student> IStudentService.GetAllStudents()
    {
        throw new NotImplementedException();
    }

    Student IStudentService.GetStudentByID(int id)
    {
        throw new NotImplementedException();
    }
}
