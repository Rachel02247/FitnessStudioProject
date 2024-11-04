using FitnessProject.Entities;
using FitnessProject.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        readonly CourseService _courseService;
        //private object result;
        public CourseController()
        {
            _courseService = new CourseService();
        }
        // GET: api/<CourseController>
        [HttpGet]
        public ActionResult<List<CourseEntity>> Get()
        {
            List<CourseEntity> result = _courseService.CourseList;
            if (result == null)
                return Unauthorized();
            return result;
        }


        // POST api/<CourseController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] CourseEntity value)
        {
            return _courseService.AddCourse(value);
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CourseEntity value)
        {
            _courseService.UpdateCourse(id, value);
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            CourseEntity current = _courseService.getID(id);
            _courseService.CourseList.Remove(current);
        }
    }
}
