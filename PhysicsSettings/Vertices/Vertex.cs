using System.Text.Json.Serialization;
using Revolt2D.Physics.PhysicsSettings.Vertices.Json;

namespace Revolt2D.Physics.PhysicsSettings.Json
{
    public class Vertex
    {
        [JsonPropertyName("Position")]
        public required Position Position;

        [JsonPropertyName("Mobility")]
        public required double Mobility;

        [JsonPropertyName("Delay")]
        public required double Delay;

        [JsonPropertyName("Acceleration")]
        public required double Acceleration;

        [JsonPropertyName("Radius")]
        public required int Radius;

        public override string ToString()
        {
            return $"      Position: {Position}\n      Mobility: {Mobility}\n      Delay: {Delay}\n      Acceleration: {Acceleration}\n      Radius: {Radius}";
        }
    }
}
