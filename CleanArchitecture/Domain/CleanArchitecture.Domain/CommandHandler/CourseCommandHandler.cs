using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;

using MediatR;

namespace CleanArchitecture.Domain.CommandHandler
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private readonly ICourseRepository _repository;

        public CourseCommandHandler(ICourseRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course
            {
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Name = request.Name,
            };

            await _repository.AddAsync(course);
            return true;
        }
    }
}
