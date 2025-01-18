using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal, promptGenerator);
                    break;

                case "2":
                    journal.DisplayAll();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;

                case "3":
                    SaveJournalToFile(journal);
                    break;

                case "4":
                    LoadJournalFromFile(journal);
                    break;

                case "5":
                    Console.WriteLine("Exiting...");    
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Write a new entry
    static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry(DateTime.Now, prompt, response);
        journal.AddEntry(newEntry);

        Console.WriteLine("Entry added successfully!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    // Save journal to file
    static void SaveJournalToFile(Journal journal)
    {
        Console.Write("Enter the filename to save to: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    // Load journal from file
    static void LoadJournalFromFile(Journal journal)
    {
        Console.Write("Enter the filename to load from: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
