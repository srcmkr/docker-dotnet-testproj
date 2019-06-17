using DDT.Api.Dto;
using DDT.Application;
using DDT.Domain;
using LiteDB;
using Microsoft.AspNetCore.Mvc;

namespace DDT.Api.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet, Route("getall")]
        public ApiResponse GetAll()
        {
            var cmp = new TaskComponent();
            return new ApiResponse
            {
                Success = true,
                Object = cmp.GetAllTasks()
            };
        }

        [HttpDelete, Route("delete")]
        public ApiResponse DeleteSingle(string id)
        {
            var cmp = new TaskComponent();
            cmp.Delete(new ObjectId(id));

            return new ApiResponse
            {
                Success = true,
            };
        }

        [HttpPost, Route("save")]
        public ApiResponse Save([FromBody]Task task)
        {
            var cmp = new TaskComponent();
            cmp.Save(task);

            return new ApiResponse
            {
                Success = true,
                Object = task
            };
        }
    }
}
