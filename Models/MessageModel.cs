namespace RabbitMessenger.Models;

public class MessageModel<T>
{
    public string? MessageType { get; set; }
    public string? CommandName { get; set; }
    public T? Payload { get; set; }

    public MessageModel()
    {
        
    }

    public MessageModel(string messageType, string commandName, T payload)
    {
        MessageType = messageType;
        CommandName = commandName;
        Payload = payload;
    }
}