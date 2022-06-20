using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Interfaces;

namespace CleanArchitecture.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public Task CreateCourseAsync(CourseViewModel course)
        {
            var command = new CreateCourseCommand(course.Name, course.Description, course.ImageUrl);
            return _bus.SendCommand(command);
        }

        public async Task<CourseViewModel?> GetCourseAsync(int id)
        {
            var course = await _courseRepository.GetCourseAsync(id);
            if (course == null)
            {
                return null;
            }
            return new CourseViewModel
            {
                Description = course.Description,
                Id = course.Id,
                ImageUrl = course.ImageUrl,
                Name = course.Name
            };
        }

        public async Task<CourseViewModel> GetCoursesAsync()
        {
            return new CourseViewModel
            {
                Courses = await _courseRepository.GetCoursesAsync()
            };
        }

    }
}
