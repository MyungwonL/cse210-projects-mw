public class ReceptionEvent : Event
{
    private string _rsvpEmail;

    public ReceptionEvent(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"2.Full Details\n{base.GetFullDetails()}\n- Type: Reception\n- RSVP Email: {_rsvpEmail}";
    }
}