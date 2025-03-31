using Microsoft.AspNetCore.Mvc;
using PetSharp.Application.UserCases.Pet.Register;
using PetSharp.Application.UserCases.Pet.Update;
using PetSharp.Communication.Requests;
using PetSharp.Communication.Responses;

namespace PetSharp.API.Controllers
{
    public class PetController : PetSharpBaseController
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredPetJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] RequestPetJson request)
        {
            var response = new RegisterPetUseCase().Execute(request);

            return Created(string.Empty, response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestPetJson request)
        {
            new UpdatePetUseCase().Execute(id, request);

            return NoContent();

        }
    }
}
