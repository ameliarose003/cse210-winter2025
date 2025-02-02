using System;
using System.Data;
using System.IO;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of Prompt
        PromptGenerator promptList = new PromptGenerator();
        string prompt1 = "Who was the most interesting person I interacted with today?";
        promptList._prompts.Add(prompt1);
        string prompt2 = "What was the best part of my day?";
        promptList._prompts.Add(prompt2);
        string prompt3 = "What was the strongest emotion I felt today?";
        promptList._prompts.Add(prompt3);
        string prompt4 = "How did I see the hand of the Lord in my life today?";
        promptList._prompts.Add(prompt4);
        string prompt5 = "If I had one thing I could do over today, what would it be?";
        promptList._prompts.Add(prompt5);


        // Ask user for their name
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        bool keepRunning = true;

        while (keepRunning)
        {

            // Display a welcome sign with their name
            Console.WriteLine($"Welcome to your journal, {userName}!");

            // Write entry, Read Journal, Load Previous journal, or Quit
            // Since it is in a while loop it will then ask them (1-4)
            Console.WriteLine("Please choose an option, 1-4: ");
            Console.WriteLine("1. Write Journal Entry");
            Console.WriteLine("2. Read Journal");
            Console.WriteLine("3. Load Previous Journal");
            Console.WriteLine("4. Quit");

            // Ask user what they would like to do, inside a while loop (1-4):
            string userChoice = Console.ReadLine();
            int numberChoice = int.Parse(userChoice);


            string safeFilename = new string(userName.Where(c => !Path.GetInvalidFileNameChars().Contains(c)).ToArray());
            if (string.IsNullOrWhiteSpace(safeFilename))
            {
                Console.WriteLine("Invalid filename. using 'default.txt'.");
                safeFilename = "default";
            }

            safeFilename = safeFilename.Replace(' ', '_');
            string filename = safeFilename + ".txt";

            Journal myJournal = new Journal();
            Entry e = new Entry();

            if (numberChoice == 1)
            {
                DateTime today = DateTime.Today;
                e._date = today;

                // For #1 Write entry, I need a prompt to load
                string entryPrompt = promptList.GetRandomPrompt();
                Console.WriteLine(entryPrompt);
                e._promptText = entryPrompt;

                // Then they need to be able to write the response
                string response = Console.ReadLine();
                e._entryText = response;

                // When they are done and click enter, it needs to be saved to a txt file that is named their name.
                string journalEntry = e.CreateEntry();
                myJournal._entries.Add(journalEntry);

                if (!File.Exists(filename))
                {
                    e.StartTxt(filename);
                }
                else
                {
                    e.AppendToTxt(filename);
                }
            }

            // When they put in #2 Read Journal, 
            if (numberChoice == 2)
            {

                myJournal.Display(filename);

            }

            // When they click #3 Load, 
            // They should be asked for the name of their .txt file and then be able to see the contents of that journal
            if (numberChoice == 3)
            {
                Console.Write("Please insert your .txt journal file name: ");
                string newFilename = Console.ReadLine();
                myJournal.Display(newFilename);

            }

            // When #4 is typed in the program should shut off, maybe with a note that says "Have a nice day!"
            if (numberChoice == 4)
            {
                keepRunning = false;
            }
        }
    }
}