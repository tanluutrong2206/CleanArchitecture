using CleanArchitecture.Domain.Core.Commands;

namespace CleanArchitecture.Domain.Commands
{
    public abstract class CourseCommand : Command
    {
        public CourseCommand()
        {
            Name = string.Empty;
            Description = string.Empty;
            ImageUrl = string.Empty;
        }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string ImageUrl { get; protected set; }
    }
}
