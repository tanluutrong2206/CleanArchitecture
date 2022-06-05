using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Interfaces
{
    public interface ICourseService
    {
        Task<CourseViewModel> GetCoursesAsync();
    }
}
