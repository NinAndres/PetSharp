using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetSharp.Communication.Requests;
using PetSharp.Communication.Responses;

namespace PetSharp.API.Controllers
{
    public class PetController : PetSharpBaseController
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredPetJson), StatusCodes.Status201Created)]
        public IActionResult Register([FromBody] RequestRegisterPetJson request)
        {
            return Created();
        }
    }
}
