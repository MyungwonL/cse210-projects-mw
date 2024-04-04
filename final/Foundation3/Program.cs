using System;

class Program
{
    static void Main(string[] args)
    {
        var lectureEvent = new LectureEvent("Lecture Title", "Lecture Description", DateTime.Now, TimeSpan.FromHours(14),
            new Address("123 Main St", "City", "State", "Country"), "John Doe", 50);

        var receptionEvent = new ReceptionEvent("Reception Title", "Reception Description", DateTime.Now, TimeSpan.FromHours(15),
            new Address("456 Elm St", "City", "State", "Country"), "rsvp@example.com");

        var outdoorGatheringEvent = new OutdoorGatheringEvent("Outdoor Gathering Title", "Outdoor Gathering Description", DateTime.Now,
            TimeSpan.FromHours(16), new Address("789 Oak St", "City", "State", "Country"), "Sunny");

        
        Console.WriteLine("Lecture Event");
        Console.WriteLine("1.Standard Description\n" + lectureEvent.GetStandardDetails());
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception Event:");
        Console.WriteLine("1.Standard Description\n" + receptionEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Event:");
        Console.WriteLine("1.Standard Description\n" + outdoorGatheringEvent.GetStandardDetails());
        Console.WriteLine(outdoorGatheringEvent.GetFullDetails());
        Console.WriteLine(outdoorGatheringEvent.GetShortDescription());
    }
    }

