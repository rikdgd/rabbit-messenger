namespace RabbitMessenger.Interfaces;

public interface IMessageHandler
{
    void HandleMessage(string message);
}