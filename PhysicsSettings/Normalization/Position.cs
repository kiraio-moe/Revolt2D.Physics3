using System.Text.Json.Serialization;

namespace Revolt2D.Physics.PhysicsSettings.Normalization.Json
{
    public class Position
    {
        [JsonPropertyName("Minimum")]
        public required int Minimum;

        [JsonPropertyName("Default")]
        public required int Default;

        [JsonPropertyName("Maximum")]
        public required int Maximum;

        public override string ToString()
        {
            return $"        Minimum: {Minimum}\n        Default: {Default}\n        Maximum: {Maximum}";
        }
    }
}
