using PetSharp.Communication.Responses;

namespace PetSharp.Application.UserCases.Pet.GetById
{
    public class GetPetByIdUseCase
    {
        public ResponsePetJson Execute(int id)
        {
            return new ResponsePetJson
            {
                Id = id,
                Name = "Charlie",
                Type = Communication.Enums.PetType.Cat,
                Birthday = new DateTime(year: 2025, month: 03, day: 31)
            };

        }
    }
}
