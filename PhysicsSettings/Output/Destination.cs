using System.Text.Json.Serialization;

namespace Revolt2D.Physics.PhysicsSettings.Output.Json
{
    public class Destination
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
