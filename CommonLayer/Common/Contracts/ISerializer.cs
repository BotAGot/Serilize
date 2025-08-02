namespace Common.Contracts
{
    internal interface ISerializer
    {
        string Serialize(IMessage message);
        IMessage Deserialize(string json);
    }
}
