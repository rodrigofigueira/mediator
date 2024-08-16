﻿namespace Chat;

public class Participant
{
    Chatroom chatroom = null!;
    readonly string name;

    // Constructor
    public Participant(string name)
    {
        this.name = name;
    }

    // Gets participant name
    public string Name
    {
        get { return name; }
    }

    // Gets chatroom
    public Chatroom Chatroom
    {
        set { chatroom = value; }
        get { return chatroom; }
    }

    // Sends message to given participant
    public void Send(string to, string message)
    {
        chatroom.Send(name, to, message);
    }

    // Receives message from given participant
    public virtual void Receive(string from, string message)
    {
        Console.WriteLine("{0} to {1}: '{2}'",
            from, Name, message);
    }
}
