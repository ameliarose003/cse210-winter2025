public class ReflectionActivity : Activity
{
    private List<string> _reflectionPrompts = new List<string>();
    private List<string> _followUpPrompts = new List<string>();
    Random _random = new Random();

    public ReflectionActivity(string startMsg, string name, string time) : base(startMsg, name, time)
    {
        MakeStartingPrompts();
        MakeFollowUpPrompts();
    }

    public void MakeStartingPrompts()
    {
        _reflectionPrompts.Add("Think of a time when you stood up for someone else.");
        _reflectionPrompts.Add("Think of a time when you did something really difficult.");
        _reflectionPrompts.Add("Think of a time when you helped someone in need.");
        _reflectionPrompts.Add("Think of a time when you did something truly selfless.");
    }

    public void MakeFollowUpPrompts()
    {
        _followUpPrompts.Add("Why was this experience meaningful to you?");
        _followUpPrompts.Add("Have you ever done anything like this before?");
        _followUpPrompts.Add("How did you get started?");
        _followUpPrompts.Add("How did you feel when it was complete?");
        _followUpPrompts.Add("What made this time different than other times when you were not as successful?");
        _followUpPrompts.Add("What is your favorite thing about this experience?");
        _followUpPrompts.Add("What could you learn from this experience that applies to other situations?");
        _followUpPrompts.Add("What did you learn about yourself through this experience?");
        _followUpPrompts.Add("How can you keep this experience in mind in the future?");
    }

    public string GetRandomStartPrompt()
    {

        int randomIndex = _random.Next(_reflectionPrompts.Count);
        string randomItem = _reflectionPrompts[randomIndex];

        return randomItem;
    }

    public void Run()
    {
        string time = Console.ReadLine();
        int totalTime = 0;

        if (int.TryParse(time, out int number))
        {
            totalTime = number;
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }
        int totalTimeInSeconds = totalTime;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(totalTimeInSeconds);
        // int index = 0;
        ShowDotDown();
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine(GetRandomStartPrompt());
            Animation(10);

            foreach (string s in _followUpPrompts)
            {
                if (DateTime.Now >= futureTime)
                {
                    break;
                }
                Console.WriteLine(s);
                Animation(10);
            }
        }
    }
}