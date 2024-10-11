using System.Text.Json.Serialization;
using Revolt2D.Physics.Meta.EffectiveForces.Json;

namespace Revolt2D.Physics.Meta.Json
{
    public class EffectiveForces
    {
        [JsonPropertyName("Gravity")]
        public required Gravity Gravity;

        [JsonPropertyName("Wind")]
        public required Wind Wind;

        public override string ToString()
        {
            return $"    Gravity: {Gravity}\n    Wind: {Wind}";
        }
    }
}
