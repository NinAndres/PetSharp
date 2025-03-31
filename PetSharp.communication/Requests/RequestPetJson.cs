using PetSharp.Communication.Enums;

namespace PetSharp.Communication.Requests
{
    public class RequestPetJson
    {
        public string Name { get; set; } = string.Empty;

        public DateTime Birthday { get; set; }

        public PetType Type { get; set; }
    }
}
