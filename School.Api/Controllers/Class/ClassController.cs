using Microsoft.AspNetCore.Mvc;
using School.Domain.Models.Class;
using School.Domain.Models.Response;
using School.Service.DTOs.Class;
using School.Service.Extencions;
using School.Service.Interfaces.Class;

namespace School.Api.Controllers.Class
{
    [Route("api/[controller]")]
    [ApiController]

    public class ClassController : ControllerBase
    {
        private readonly IClassService classService;

        public ClassController(IClassService classService)
        {
            this.classService = classService;
        }

        [HttpGet("get/all")]
        [ProducesResponseType(typeof(ResponseModel<ClassModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseModel<>), StatusCodes.Status400BadRequest)]
        public async ValueTask<IActionResult> GetAllAsync() => ResponseHandler.ReturnIActionResponse(await classService.GetAsync());


        [HttpPost("create")]
        [ProducesResponseType(typeof(ResponseModel<ClassModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseModel<>), StatusCodes.Status400BadRequest)]
        public async ValueTask<IActionResult> CreateAsync(ClassForCreationDTO @dto) => ResponseHandler.ReturnIActionResponse(await classService.CreateAsync(@dto));


        [HttpGet("get")]
        [ProducesResponseType(typeof(ResponseModel<ClassModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseModel<>), StatusCodes.Status400BadRequest)]
        public async ValueTask<IActionResult> GetByIdAsync(int id) => ResponseHandler.ReturnIActionResponse(await classService.GetById(id));


        [HttpPost("update")]
        [ProducesResponseType(typeof(ResponseModel<ClassModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseModel<>), StatusCodes.Status400BadRequest)]
        public async ValueTask<IActionResult> UpdateAsync(int id, ClassForCreationDTO @dto) => ResponseHandler.ReturnIActionResponse(await classService.UpdateAsync(id, @dto));

        [HttpDelete("delete")]
        [ProducesResponseType(typeof(ResponseModel<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseModel<>), StatusCodes.Status400BadRequest)]
        public async ValueTask<IActionResult> DeleteAsync(int id) => ResponseHandler.ReturnIActionResponse(await classService.DeleteAsync(id));
    }
}
