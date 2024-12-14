using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Oak St", "Austin", "TX", "USA");

        // Create events
        Lecture lecture = new Lecture("Tech Talk", "A talk on the latest in tech", "2024-12-20", "10:00 AM", address1, "John Doe", 100);
        Reception reception = new Reception("Networking Event", "An event to network with professionals", "2024-12-21", "6:00 PM", address2, "rsvp@example.com");
        Outdoor outdoor = new Outdoor("Community Picnic", "A picnic for the community", "2024-12-22", "12:00 PM", address3, "Sunny with a chance of rain");

        // Display event details
        Event[] events = { lecture, reception, outdoor };

        foreach (Event ev in events)
        {
            Console.WriteLine(ev.DisplayStandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.DisplayFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.DisplayShortDescription());
            Console.WriteLine();
        }
    }
}