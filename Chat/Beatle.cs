namespace Chat;

public class Beatle(string name) : Participant(name)
{
    public override void Receive(string from, string message)
    {
        Console.Write("To a Beatle: ");
        base.Receive(from, message);
    }
}
