namespace Chat;

public class NonBeatle(string name) : Participant(name)
{
    public override void Receive(string from, string message)
    {
        Console.Write("To a NonBeatle: ");
        base.Receive(from, message);
    }
}
