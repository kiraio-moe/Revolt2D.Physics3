using System.Text.Json.Serialization;
using Revolt2D.Physics.PhysicsSettings.Output.Json;

namespace Revolt2D.Physics.PhysicsSettings.Json
{
    public class Output
    {
        [JsonPropertyName("Destination")]
        public required Destination Destination;

        [JsonPropertyName("VertexIndex")]
        public required int VertexIndex;

        [JsonPropertyName("Scale")]
        public required double Scale;

        [JsonPropertyName("Weight")]
        public required int Weight;

        [JsonPropertyName("Type")]
        public required string Type;

        [JsonPropertyName("Reflect")]
        public required bool Reflect;

        public override string ToString()
        {
            return $"      Destination: {Destination}\n      Vertex Index: {VertexIndex}\n      Scale: {Scale}\n      Weight: {Weight}\n      Type: {Type}\n      Reflect: {Reflect}";
        }
    }
}
