public class ReflectionManager()
{
    BreathingActivity breather = new BreathingActivity("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "Breathing Activity", "How long in seconds would you like to do this breathing activity? ");
    ListingActivity listing = new ListingActivity("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Listing Activity", "How long in seconds would you like to do this listing activity? ");
    ReflectionActivity reflection = new ReflectionActivity("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Reflection Activity", "How long in seconds would you like to do this reflection activity? ");

    public void RunSession()
    {
        string choice;
        Console.WriteLine("Welcome to the calmist Meditation");
        do
        {
            DisplayMenu();
            choice = Console.ReadLine();
            if (choice == "1" || choice == "Breathing Activity")
            {
                breather.Run();
                breather.ShowEnding();

            }
            else if (choice == "2" || choice == "Listing Activity")
            {
                listing.Run();
                listing.ShowEnding();


            }
            else if (choice == "3" || choice == "Reflection Activity")
            {
                reflection.Run();
                reflection.ShowEnding();
            }
            else if (choice == "4")
            {
                Console.WriteLine("GoodBye!");

            }
            else
            {
                Console.WriteLine("I didn't quite get that.....");
            }

        } while (choice != "quit" && choice != "4");
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Please choose an activity to begin:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflection Activity");
        Console.WriteLine("4. Quit");
    }

}