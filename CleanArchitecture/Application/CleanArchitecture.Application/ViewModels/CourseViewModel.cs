using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.ViewModels
{
    public class CourseViewModel
    {
        public CourseViewModel()
        {
            Courses = new List<Course>();
            Name = string.Empty;
            Description = string.Empty;
            ImageUrl = string.Empty;
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }   
}
