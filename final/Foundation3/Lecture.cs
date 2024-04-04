public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"2.Full Details\n{base.GetFullDetails()}\n- Type: Lecture\n- Speaker: {_speaker}\n- Capacity: {_capacity}";
    }
}