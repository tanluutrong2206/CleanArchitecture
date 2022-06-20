using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;

using Microsoft.AspNetCore.Mvc;

using System.Net;

namespace CleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _service;

        public CourseController(ICourseService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CourseViewModel>> GetById(int id)
        {
            var course = await _service.GetCourseAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            return course;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CourseViewModel>> Create([FromBody] CourseViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _service.CreateCourseAsync(viewModel);
            return CreatedAtAction(nameof(GetById), new { id = viewModel.Id }, viewModel);
        }
    }
}
