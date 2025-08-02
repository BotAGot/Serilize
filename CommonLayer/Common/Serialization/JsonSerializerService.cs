using Common.Contracts;
using Common.Models;
using System.Text.Json;

namespace Common.Serialization
{
    internal class JsonSerializerService : ISerializer
    {
        public IMessage Deserialize(string json)
        {
            var temp = JsonSerializer.Deserialize<GenericMessage>(json);
            var type = Type.GetType(temp.Type);
            
            if (type == null)
            {
                return temp;
            }

            var rawJson = JsonSerializer.Serialize(temp.Value);
            var typedValue = JsonSerializer.Deserialize(rawJson, type);
            return new GenericMessage(typedValue!);
        }

        public string Serialize(IMessage message)
        {
            return JsonSerializer.Serialize(message);
        }
    }
}
