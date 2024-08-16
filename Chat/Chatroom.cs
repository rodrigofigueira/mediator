namespace Chat;

public class Chatroom : AbstractChatRoom
{
    private Dictionary<string, Participant> participants = new();

    public override void Register(Participant participant)
    {
        if (!participants.ContainsValue(participant))
        {
            participants[participant.Name] = participant;
        }

        participant.Chatroom = this;
    }

    public override void Send(string from, string to, string message)
    {
        Participant participant = participants[to];

        if (participant == null)
        {
            return;
        }
        participant.Receive(from, message);
    }
}
