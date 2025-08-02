using Common.Contracts;

namespace Common.Models
{
    [Serializable]
    internal class GenericMessage : IMessage
    {
        public string Type { get; set; }
        public object Value { get; set; }
        public GenericMessage() { }
        public GenericMessage(object value)
        {
            Value = value;
            Type = value?.GetType().AssemblyQualifiedName ?? "null";
        }
    }
}
