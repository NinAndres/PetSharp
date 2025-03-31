using PetSharp.Communication.Requests;
using PetSharp.Communication.Responses;

namespace PetSharp.Application.UserCases.Pet.Register
{
    public class RegisterPetUseCase
    {
        public ResponseRegisteredPetJson Execute(RequestPetJson request)
        {
            return new ResponseRegisteredPetJson
            {
                Id = 7,
                Name = request.Name,
            };
        }
    }
}
