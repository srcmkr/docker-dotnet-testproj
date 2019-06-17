using DDT.Api.Dto;
using DDT.Domain;
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
            var cmp = new TasksController();
            return new ApiResponse
            {
                Success = true,
                Object = cmp.GetAll()
            };
        }

        [HttpDelete, Route("delete")]
        public ApiResponse DeleteSingle(string id)
        {
            var cmp = new TasksController();
            cmp.DeleteSingle(id);

            return new ApiResponse
            {
                Success = true,
            };
        }

        [HttpPost, Route("save")]
        public ApiResponse Save([FromBody]Task task)
        {
            var cmp = new TasksController();
            cmp.Save(task);

            return new ApiResponse
            {
                Success = true,
                Object = task
            };
        }
    }
}
