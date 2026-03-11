using System;

class ChatLogger
{
    public void SendMessage(string sender, string message)
    {
        Console.WriteLine($"[로그] {sender}: {message}");
    }
}