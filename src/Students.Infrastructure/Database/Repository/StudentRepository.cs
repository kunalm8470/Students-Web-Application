using Microsoft.EntityFrameworkCore;
using Students.Domain.Exceptions;
using Students.Domain.Interfaces.Repository;
using Students.Domain.Models;
using X.PagedList;

namespace Students.Infrastructure.Database.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolDbContext _context;
     
        public StudentRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public async Task AddStudentAsync(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
        }

        public async Task<int> CountAsync()
        {
            return await _context.Students.CountAsync();
        }

        public async Task DeleteStudentAsync(int id)
        {
            Student found = await _context.Students.FindAsync(id);

            if (found is null)
            {
                throw new StudentNotFoundException();
            }

            _context.Students.Remove(found);

            await _context.SaveChangesAsync();
        }

        public async Task<Student> GetStudentsByIdAsync(int id)
        {
            // Find by primary key
            return await _context.Students.FindAsync(id);
        }

        public async Task<IPagedList<Student>> ListStudentsAsync(int page, int limit)
        {
            return await _context.Students
            .OrderByDescending(s => s.Id)
            .ToPagedListAsync(page, limit);
        }

        public async Task UpdateStudentAsync(int id, Student student)
        {
            Student found = await _context.Students.FindAsync(id);

            if (found is null)
            {
                throw new StudentNotFoundException();
            }

            found.FirstName = student.FirstName;

            found.LastName = student.LastName;

            found.DateOfBirth = student.DateOfBirth;

            found.Gender = student.Gender;

            await _context.SaveChangesAsync();
        }
    }
}
