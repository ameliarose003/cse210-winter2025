using System.Security.Cryptography;

public class ListingActivity : Activity
{
    private List<string> _listingPrompts = new List<string>();
    private int _responseCount = 0;
    private Random _random = new Random();
    private bool isUsed = true;


    public ListingActivity(string startMsg, string name, string time) : base(startMsg, name, time)
    {
        MakePrompts();
        // _listeningPrompts = prompts;
    }


    private List<string> MakePrompts()
    {
        // string prompt1 = "Who are people that you appreciate?";
        _listingPrompts.Add("Who are people that you appreciate?");
        _listingPrompts.Add("What are personal strengths of yours?");
        _listingPrompts.Add("Who are people that you have helped this week?");
        _listingPrompts.Add("When have you felt the Holy Ghost this month?");
        _listingPrompts.Add("Who are some of your personal heroes?");
        return _listingPrompts;
    }

    public string GetRandomPrompt()
    {
        do
        {
            int randomIndex = _random.Next(_listingPrompts.Count);
            string randomItem = _listingPrompts[randomIndex];

            return randomItem;
        }
        while (isUsed);
    }

    // public void CountDown()
    // {

    // }

    public void Run()
    {
        string time = Console.ReadLine();
        int totalTime = 0;
        // int timeCount = 0;
        // int CounterIndex = 0;
        if (int.TryParse(time, out int number))
        {
            totalTime = number;
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }
        int localResponseCount = 1;
        int totalTimeInSeconds = totalTime + 5;
        Animation(5);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(totalTimeInSeconds);
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine(GetRandomPrompt());
            CountDown();
            Console.ReadLine();
            if (DateTime.Now >= futureTime)
            {
                break;
            }
            _responseCount++;
            localResponseCount++;

        }
        Console.WriteLine($"You answered {localResponseCount} questions.");
        if (_responseCount > localResponseCount)
        {
            Console.WriteLine($"You answered {_responseCount} questions in total.");

        }

    }


}