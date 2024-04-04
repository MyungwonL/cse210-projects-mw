public class OutdoorGatheringEvent : Event
{
    private string _weatherForecast;

    public OutdoorGatheringEvent(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"2.Full Details\n{base.GetFullDetails()}\n- Type: Outdoor Gathering\n- Weather Forecast: {_weatherForecast}";
    }
}