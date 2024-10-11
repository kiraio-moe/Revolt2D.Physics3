using System.Text.Json.Serialization;
using Revolt2D.Physics.PhysicsSettings.Input.Json;

namespace Revolt2D.Physics.PhysicsSettings.Json
{
    public class Input
    {
        [JsonPropertyName("Source")]
        public required Source Source;

        [JsonPropertyName("Weight")]
        public required int Weight;

        [JsonPropertyName("Type")]
        public required string Type;

        [JsonPropertyName("Reflect")]
        public required bool Reflect;

        public override string ToString()
        {
            return $"      Source: {Source}\n      Weight: {Weight}\n      Type: {Type}\n      Reflect: {Reflect}";
        }
    }
}
