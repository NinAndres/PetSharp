﻿using Microsoft.AspNetCore.Mvc;
using PetSharp.Application.UserCases.Pet.Delete;
using PetSharp.Application.UserCases.Pet.GetAll;
using PetSharp.Application.UserCases.Pet.GetById;
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

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllPetJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAllShort()
        {
            var response = new GetAllPetsUseCase().Execute();

            if (response.Pets.Any())
            {
                return Ok(response);
            }

            return NoContent();
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponsePetJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            var response = new GetPetByIdUseCase().Execute(id);

            return Ok(response);
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {
            new DeletePetById().Execute(id);

            return NoContent();
        }

    }
}
