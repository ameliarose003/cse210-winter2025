class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // make a list of the jobs and print each job in the resume list below.

    public void DisplayName()
    {
        Console.WriteLine($"Name: {_name}");
    }
    public void Display()
    {
        Console.WriteLine($"Job Title: {_jobs}");
    }
}