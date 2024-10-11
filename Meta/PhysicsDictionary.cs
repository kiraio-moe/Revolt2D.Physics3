using System.Text.Json.Serialization;

namespace Revolt2D.Physics.Meta.Json
{
    public class PhysicsDictionary
    {
        [JsonPropertyName("Id")]
        public required string Id;

        [JsonPropertyName("Name")]
        public required string Name;

        public override string ToString()
        {
            return $"      Id: {Id}\n      Name: {Name}";
        }
    }
}
