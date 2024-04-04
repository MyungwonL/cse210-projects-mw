public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"- Title: {_title}\n- Description: {_description}\n- Date: {_date.ToShortDateString()}\n- Time: {_time.ToString()}\n- Address: {_address.ToString()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"3.Short Description\n- Type: Event\n- Title: {_title}\n- Date: {_date.ToShortDateString()}";
    }
}