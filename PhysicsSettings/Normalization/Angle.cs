using System.Text.Json.Serialization;

namespace Revolt2D.Physics.PhysicsSettings.Normalization.Json
{
    public class Angle
    {
        [JsonPropertyName("Minimum")]
        public required double Minimum;

        [JsonPropertyName("Default")]
        public required int Default;

        [JsonPropertyName("Maximum")]
        public required double Maximum;

        public override string ToString()
        {
            return $"        Minimum: {Minimum}\n        Default: {Default}\n        Maximum: {Maximum}";
        }
    }
}
