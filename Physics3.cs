using System.Text.Json.Serialization;
using Revolt2D.Physics.Meta.Json;
using Revolt2D.Physics.PhysicsSettings.Json;

namespace Revolt2D.Physics.Json
{
    public class Physics3
    {
        [JsonPropertyName("Version")]
        public required int Version;

        [JsonPropertyName("Meta")]
        public required Meta Meta;

        [JsonPropertyName("PhysicsSettings")]
        public required List<PhysicsSetting> PhysicsSettings;

        public override string ToString()
        {
            string physicsSettingsString = string.Join(
                "\n",
                PhysicsSettings.Select((p, i) => $"    Physics Settings[{i}]:\n{p}")
            );
            return $"Version: {Version}\nMeta: {Meta}\nPhysics Settings: {physicsSettingsString}";
        }
    }
}
