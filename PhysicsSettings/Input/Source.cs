using System.Text.Json.Serialization;

namespace Revolt2D.Physics.PhysicsSettings.Input.Json
{
    public class Source
    {
        [JsonPropertyName("Target")]
        public required string Target;

        [JsonPropertyName("Id")]
        public required string Id;

        public override string ToString()
        {
            return $"        Target: {Target}\n        Id: {Id}";
        }
    }
}
