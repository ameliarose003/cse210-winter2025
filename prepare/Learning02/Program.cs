using System;
using System.Data;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("Menu: ");
        Console.WriteLine(" 1. Add new job: ");
        Console.WriteLine(" 2. Display resume: ");
        Console.WriteLine(" 3. Quit: ");
        Console.WriteLine();

    }
    static void Main(string[] args)
    {
        Resume theResume = new Resume();


        bool keepRunning = true;

        while (keepRunning)
        {
            DisplayMenu();

            Console.Write("Please enter your choice (1-3): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // Add new job
                Console.Write(" What is the name of the company? ");
                string company = Console.ReadLine();

                Console.Write(" What is your position? ");
                string position = Console.ReadLine();

                Job newJob = new Job();
                newJob._company = company;
                newJob._jobTitle = position;
                newJob._startYear = 2015;
                newJob._endYear = 2025;

                theResume._jobs.Add(newJob);
            }
            else if (choice == "2")
            {
                //  Display resume
                theResume.Display();
            }
            else if (choice == "3")
            {
                // Quit
                keepRunning = false;
            }
            else
            {
                // Unexpected input
                Console.WriteLine("Sorry, invalid answer, try again!");
            }
        }



        // Job job1 = new Job();
        // job1._company = "Family Search";
        // job1._jobTitle = "Web developer";
        // job1._startYear = 2024;
        // job1._endYear = 2027;

        // Job job2 = new Job();
        // job2._company = "Mesa Falls";
        // job2._jobTitle = "Maintenance Worker";
        // job2._startYear = 2022;
        // job2._endYear = 2024;


        // Resume resume1 = new Resume();
        // // resume1._jobs = "Web Developer";
        // resume1._name = "John Doe";
        // resume1._jobs.Add(job1);
        // resume1._jobs.Add(job2);

        // resume1.DisplayName();
        // Console.WriteLine("Jobs:");
        // foreach (var job in resume1._jobs)
        // {
        //     job.DisplayJobs();
        // }
        // resume1.DisplayJobs();


        // job1.Display();
        // resume1.Display(jobs);
    }
}