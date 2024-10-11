using System.Text.Json.Serialization;
using Revolt2D.Physics.PhysicsSettings.Normalization.Json;

namespace Revolt2D.Physics.PhysicsSettings.Json
{
    public class Normalization
    {
        [JsonPropertyName("Position")]
        public required Position Position;

        [JsonPropertyName("Angle")]
        public required Angle Angle;

        public override string ToString()
        {
            return $"      Position: {Position}\n      Angle: {Angle}";
        }
    }
}
