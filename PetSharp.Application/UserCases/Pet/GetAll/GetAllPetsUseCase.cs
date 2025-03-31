using PetSharp.Communication.Responses;

namespace PetSharp.Application.UserCases.Pet.GetAll
{
    public class GetAllPetsUseCase
    {
        public ResponseAllPetJson Execute()
        {
            return new ResponseAllPetJson
            {
                Pets = new List<ResponseShortPetJson>
                {
                    new ResponseShortPetJson {
                        Id = 1,
                        Name = "Ayla",
                        Type = Communication.Enums.PetType.Dog

                    }

                }
            };
        }
    }
}
