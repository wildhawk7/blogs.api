using blogs.api.Models;
using blogs.api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blogs.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly BlogRepository _repository;

        public BlogsController(BlogRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Blogs>> Get()
        {
            return await _repository.GetBlogsAsync();
        }
    }
}
