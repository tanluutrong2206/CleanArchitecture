using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.ViewModels
{
    public class CourseViewModel
    {
        public CourseViewModel()
        {
            Courses = new List<Course>();
        }

        public IEnumerable<Course> Courses { get; set; }
    }   
}
