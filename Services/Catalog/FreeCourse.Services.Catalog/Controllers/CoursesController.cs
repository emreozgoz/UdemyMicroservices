using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Services.Catalog.Services;
using FreeCourse.Shared.ControllerBases;
using Microsoft.AspNetCore.Mvc;

namespace FreeCourse.Services.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : CustomBaseController
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var response = await _courseService.GetById(id);
            return CreateActionResultBase(response);
        }
        public async Task<IActionResult> GetAll()
        {
            var response = await _courseService.GetAllAsync();
            return CreateActionResultBase(response);
        }

        [Route("api/[controller]/GetAllUserByIdAsync/{userId}")]
        public async Task<IActionResult> GetAllUserByIdAsync(string userId)
        {
            var response = await _courseService.GetAllUserByIdAsync(userId);
            return CreateActionResultBase(response);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CourseCreateDto courseCreateDto)
        {
            var response = await _courseService.CreateAsync(courseCreateDto);
            return CreateActionResultBase(response);
        }
        [HttpPut]
        public async Task<IActionResult> Update(CourseUpdateDto courseUpdateDto)
        {
            var response = await _courseService.UpdateAsync(courseUpdateDto);
            return CreateActionResultBase(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var response = await _courseService.DeleteAsync(id);
            return CreateActionResultBase(response);
        }

    }
}
