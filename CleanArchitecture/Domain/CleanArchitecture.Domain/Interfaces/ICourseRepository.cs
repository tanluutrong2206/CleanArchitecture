using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface ICourseRepository
    {
        Task<IEnumerable<Course>> GetCoursesAsync();
        Task<Course> GetCourseAsync(int id);
        Task AddAsync(Course course);
    }
}
