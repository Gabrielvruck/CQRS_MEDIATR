using Application.Commands.AddStudent;
using Application.Queries.GetStudents;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var getStudentsQuery = new GetStudentsQuery();

            var result = await _mediator.Send(getStudentsQuery);

            return Ok(result);
        }

        public async Task<AddStudentViewModel> Cadastro([FromServices] IMediator mediator, [FromBody] AddStudentCommand request)
        {
            return await mediator.Send(request);
        }
    }
}
