using System.Text.Json;

namespace Revolt2D.Physics.Json
{
    public class Physics3Loader
    {
        private Physics3 _physics;

        public Physics3Loader(string filePath)
        {
            _physics = LoadFromFile(filePath);
        }

        public Physics3 GetPhysics()
        {
            return _physics;
        }

        public Physics3? LoadFromFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                throw new Exception($"Invalid path! {filePath}");

            string? jsonData = File.ReadAllText(filePath);
            return LoadJson(jsonData);
        }

        public Physics3? LoadJson(string jsonData)
        {
            try
            {
                if (string.IsNullOrEmpty(jsonData))
                    throw new Exception("JSON data empty!");

                JsonSerializerOptions options = new JsonSerializerOptions { IncludeFields = true };
                return JsonSerializer.Deserialize<Physics3>(jsonData, options);
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }
    }
}
