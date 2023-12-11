namespace RabbitMessenger.Interfaces;

public interface IMessenger
{
    void SendMessage(string message);
}