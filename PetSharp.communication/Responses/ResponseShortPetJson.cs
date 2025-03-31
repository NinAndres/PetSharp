using PetSharp.Communication.Enums;

namespace PetSharp.Communication.Responses
{
    public class ResponseShortPetJson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public PetType Type { get; set; }
    }
}
