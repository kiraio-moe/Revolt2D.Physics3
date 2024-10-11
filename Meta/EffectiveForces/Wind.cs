using System.Text.Json.Serialization;

namespace Revolt2D.Physics.Meta.EffectiveForces.Json
{
    public class Wind
    {
        [JsonPropertyName("X")]
        public required int X;

        [JsonPropertyName("Y")]
        public required int Y;

        public override string ToString()
        {
            return $"      X: {X}\n      Y: {Y}";
        }
    }
}
