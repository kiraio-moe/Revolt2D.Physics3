using System.Text.Json.Serialization;
using Revolt2D.Physics.Meta.EffectiveForces.Json;
using Revolt2D.Physics.Meta.Json;

namespace Revolt2D.Physics.Json
{
    public class Meta
    {
        [JsonPropertyName("PhysicsSettingCount")]
        public required int PhysicsSettingCount;

        [JsonPropertyName("TotalInputCount")]
        public required int TotalInputCount;

        [JsonPropertyName("TotalOutputCount")]
        public required int TotalOutputCount;

        [JsonPropertyName("VertexCount")]
        public required int VertexCount;

        [JsonPropertyName("EffectiveForces")]
        public required EffectiveForces EffectiveForces;

        [JsonPropertyName("PhysicsDictionary")]
        public required List<PhysicsDictionary> PhysicsDictionary;

        public override string ToString()
        {
            string physicsDictionaryString = string.Join(
                "\n",
                PhysicsDictionary.Select((p, i) => $"    Physics Dictionary[{i}]\n{p}")
            );
            return $"  Physics Setting Count: {PhysicsSettingCount}\n  Total Input Count: {TotalInputCount}\n    Total Output Count: {TotalInputCount}\n  Vertex Count: {VertexCount}\n  Effective Forces: {EffectiveForces}\n  Physics Dictionary: {physicsDictionaryString}";
        }
    }
}
