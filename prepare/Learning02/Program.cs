using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Family Search";
        job1._jobTitle = "Web developer";
        job1._startYear = 2024;
        job1._endYear = 2027;

        Job job2 = new Job();
        job2._company = "Mesa Falls";
        job2._jobTitle = "Maintenance Worker";
        job2._startYear = 2022;
        job2._endYear = 2024;


        Resume resume1 = new Resume();
        // resume1._jobs = "Web Developer";
        resume1._name = "John Doe";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayName();
        Console.WriteLine("Jobs:");
        foreach (var job in resume1._jobs)
        {
            job.DisplayJobs();
        }
        // resume1.DisplayJobs();


        // job1.Display();
        // resume1.Display(jobs);
    }
}