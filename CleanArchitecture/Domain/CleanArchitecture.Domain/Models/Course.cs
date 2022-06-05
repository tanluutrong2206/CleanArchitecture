namespace CleanArchitecture.Domain.Models
{
    public class Course
    {
        public Course()
        {
            Name = string.Empty;
            Description = string.Empty;
            ImageUrl = string.Empty;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

    }
}
