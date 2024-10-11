using System.Text.Json.Serialization;
using Revolt2D.Physics.PhysicsSettings.Json;

namespace Revolt2D.Physics.Json
{
    public class PhysicsSetting
    {
        [JsonPropertyName("Id")]
        public required string Id;

        [JsonPropertyName("Input")]
        public required List<Input> Input;

        [JsonPropertyName("Output")]
        public required List<Output> Output;

        [JsonPropertyName("Vertices")]
        public required List<Vertex> Vertices;

        [JsonPropertyName("Normalization")]
        public required Normalization Normalization;

        public override string ToString()
        {
            string inputString = string.Join(
                "\n",
                Input.Select((i, index) => $"    Input[{index}]:\n{i}")
            );
            string outputString = string.Join("\n", Output.Select((o, i) => $"    Output[{i}]:\n{o}"));
            string verticesString = string.Join(
                "\n",
                Vertices.Select((v, i) => $"    Vertices[{i}]:\n{v}")
            );
            return $"  Id: {Id}\n  Input: {inputString}\n  Output: {outputString}\n  Vertices: {verticesString}\n  Normalization: {Normalization}";
        }
    }
}
