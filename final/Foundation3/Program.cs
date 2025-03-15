using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("123 Tech Avenue", "Silicon Valley", "CA");
        string fullA1 = a1.SetAddress();
        Lectures l = new Lectures("Dr. Jane Smith", 150, "Innovations in AI", "An in-depth lecture about recent breakthroughs in artificial intelligence, exploring trends, research advancements, and future implications.", "2025-04-20", "18:00", fullA1);
        Console.WriteLine("Standard Details");
        Console.WriteLine(l.DisplayStandardDetails());
        Console.WriteLine("Full Details");
        Console.WriteLine(l.DisplayFullDetail() + l.DisplayLectureDetail());
        Console.WriteLine("Short Description");
        Console.WriteLine(l.ShortDescription());
        Console.WriteLine();

        Address a2 = new Address("456 Grand Ballroom", "Downtown", "NY");
        string fullA2 = a2.SetAddress();
        Receptions r = new Receptions("maryreceptions@events.com", "Spring Gala Reception", "A formal evening event featuring elegant decor, gourmet refreshments, and opportunities to network with industry leaders.", "2025-05-15", "19:30", fullA2);
        Console.WriteLine("Standard Details");
        Console.WriteLine(r.DisplayStandardDetails());
        Console.WriteLine("Full Details");
        Console.WriteLine(r.DisplayFullDetail() + r.DisplayReceptionDetail());
        Console.WriteLine("Short Description");
        Console.WriteLine(r.ShortDescription());
        Console.WriteLine();

        Address a3 = new Address("789 Green Park Road", "Springfield", "IL");
        string fullA3 = a3.SetAddress();
        OutdoorGatherings o = new OutdoorGatherings("Partly Cloudy", "Community Park Meetup", "A casual outdoor event held in the local park with games, food trucks, and activities designed to foster community spirit.", "2025-06-10", "15:00", fullA3);
        Console.WriteLine("Standard Details");
        Console.WriteLine(o.DisplayStandardDetails());
        Console.WriteLine("Full Details");
        Console.WriteLine(o.DisplayFullDetail() + o.DisplayOutdoorGatheringDetail());
        Console.WriteLine("Short Description");
        Console.WriteLine(o.ShortDescription());
    }
}