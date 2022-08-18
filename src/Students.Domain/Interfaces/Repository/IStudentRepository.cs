using Students.Domain.Models;
using X.PagedList;

namespace Students.Domain.Interfaces.Repository
{
    public interface IStudentRepository
    {
        Task<IPagedList<Student>> ListStudentsAsync(int page, int limit);

        Task<int> CountAsync();

        Task<Student> GetStudentsByIdAsync(int id);

        Task AddStudentAsync(Student student);

        Task UpdateStudentAsync(int id, Student student);

        Task DeleteStudentAsync(int id);
    }
}
