using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Interfaces
{
    public interface ICourseService
    {
        Task CreateCourseAsync(CourseViewModel course);
        Task<CourseViewModel?> GetCourseAsync(int id);
        Task<CourseViewModel> GetCoursesAsync();
    }
}
