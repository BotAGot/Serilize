namespace Common.Contracts
{
    internal interface IMessage
    {
        string Type { get; set; }
        object Value { get; set; }
    }
}
