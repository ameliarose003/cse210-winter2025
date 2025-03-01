public class Activity
{
    private string _startMsg;
    private string _name;
    public string _time;

    public Activity(string startMsg, string name, string time)
    {
        _startMsg = startMsg;
        _name = name;
        _time = time;
    }

    public void DisplayMessage()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_startMsg);
        Console.Write(_time);
    }
    public void Animation(int durationSeconds)
    {
        int breatheDuration = durationSeconds * 1000;
        int delay = 500;

        List<string> animatedChar = new List<string> { "^", "<", "v", ">" };

        int index = 0;
        int elapsed = 0;


        while (elapsed < breatheDuration)
        {
            Console.Write(animatedChar[index]);
            Thread.Sleep(delay);
            Console.Write("\b");

            elapsed += delay;
            index = (index + 1) % animatedChar.Count;
        }
    }


    public void GetTime()
    {

    }

    public void CountDown()
    {
        for (int i = 5; i > -1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
            // Console.Write(" ");
        }
        // for (int i = 0; i > 0;)
        // {
        //     Console.Write(" ");
        //     Thread.Sleep(1000);
        //     Console.Write("\b\b");
        // }
        Console.WriteLine();

    }

    public void ShowDotDown()
    {
        Console.Write("Loading");
        for (int i = 5; i > 0; i--)
        {
            Console.Write('.');
            Thread.Sleep(1000);
        }
        for (int i = 0; i < 6; i++)
        {
            Console.Write(" ");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine();
    }

    public void BreatheIn(int durationSeconds)
    {
        int breatheDuration = durationSeconds * 1000;
        int breatheDurationHalf = breatheDuration / 3;
        int delay = 700;
        int delayHalf = 350;

        int elapsed = 0;
        while (elapsed < breatheDurationHalf)
        {
            Console.Write('<');
            Thread.Sleep(delayHalf);
            elapsed += delayHalf;
        }
        while (elapsed < breatheDuration)
        {


            Console.Write('<');
            Thread.Sleep(delay);

            // Thread.Sleep(delay);
            // Console.Write("\b");

            elapsed += delay;
        }


    }

    public void BreatheOut(int durationSeconds)
    {
        int breatheDuration = durationSeconds * 1000;
        int breatheDurationHalf = breatheDuration / 3;
        int delay = 700;
        int delayHalf = 350;

        int elapsed = 0;
        while (elapsed < breatheDurationHalf)
        {
            Console.Write('>');
            Thread.Sleep(delayHalf);
            elapsed += delayHalf;
        }
        while (elapsed < breatheDuration)
        {


            Console.Write('>');
            Thread.Sleep(delay);

            // Thread.Sleep(delay);
            // Console.Write("\b");

            elapsed += delay;
        }
    }

    public void ShowEnding()
    {
        Console.WriteLine();
        Console.WriteLine("Thank you for using The Calmist Meditation for this activity");
        Console.WriteLine();
    }
}