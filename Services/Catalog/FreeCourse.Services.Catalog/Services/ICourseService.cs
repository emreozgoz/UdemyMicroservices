using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Services.Catalog.Models;
using FreeCourse.Shared.Dtos;

namespace FreeCourse.Services.Catalog.Services
{
    public interface ICourseService
    {
        Task<Response<List<CourseDto>>> GetAllAsync();
        Task<Response<CourseDto>> CreateAsync(CourseCreateDto courseCreateDto);
        Task<Response<CourseDto>> GetById(string id);
        Task<Response<List<CourseDto>>> GetAllUserByIdAsync(string userId);

        Task<Response<NoContent>> DeleteAsync(string id);

        Task<Response<NoContent>> UpdateAsync(CourseUpdateDto courseUpdateDto);
    }
}
