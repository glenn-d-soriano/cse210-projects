using System;
using System.Collections.Generic;

namespace EternalQuest
{
    class Program
    {
        static List<Goal> goals = new List<Goal>();
        static int totalScore = 0;

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Eternal Quest Goal Tracker");
                Console.WriteLine("===========================");
                Console.WriteLine("1. Create a new goal");
                Console.WriteLine("2. Record an event for a goal");
                Console.WriteLine("3. Display all goals");
                Console.WriteLine("4. Display current score");
                Console.WriteLine("5. Exit");
                Console.Write("Please select an option (1-5): ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        RecordEvent();
                        break;
                    case "3":
                        DisplayGoals();
                        break;
                    case "4":
                        DisplayScore();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        static void CreateGoal()
        {
            Console.Clear();
            Console.WriteLine("Select the type of goal to create:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Please select an option (1-3): ");
            var goalType = Console.ReadLine();

            Console.Write("Enter the name of the goal: ");
            var name = Console.ReadLine();

            int points;
            while (true)
            {
                Console.Write("Enter the points for the goal: ");
                if (int.TryParse(Console.ReadLine(), out points))
                {
                    break; // Exit the loop if parsing is successful
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for points.");
                }
            }

            switch (goalType)
            {
                case "1":
                    goals.Add(new SimpleGoal(name, points));
                    break;
                case "2":
                    goals.Add(new EternalGoal(name, points));
                    break;
                case "3":
                    int requiredCompletions;
                    int bonusPoints;

                    while (true)
                    {
                        Console.Write("Enter the number of required completions: ");
                        if (int.TryParse(Console.ReadLine(), out requiredCompletions) && requiredCompletions > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number greater than 0 for required completions.");
                        }
                    }

                    while (true)
                    {
                        Console.Write("Enter the bonus points for completing the goal: ");
                        if (int.TryParse(Console.ReadLine(), out bonusPoints) && bonusPoints >= 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number for bonus points.");
                        }
                    }

                    goals.Add(new ChecklistGoal(name, points, requiredCompletions, bonusPoints));
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    break;
            }

            Console.WriteLine($"Goal '{name}' added successfully!");
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
        }

        static void RecordEvent()
        {
            Console.Clear();
            if (goals.Count == 0)
            {
                Console.WriteLine("You have no goals created yet. Please create some goals first.");
                Console.WriteLine("Press any key to return to the menu.");
                Console.ReadKey();
                return;
            }

            DisplayGoals();
            int goalIndex = -1;
            while (goalIndex < 0 || goalIndex >= goals.Count)
            {
                Console.Write("Enter the number of the goal you want to record an event for: ");
                if (int.TryParse(Console.ReadLine(), out goalIndex) && goalIndex >= 1 && goalIndex <= goals.Count)
                {
                    goalIndex--; // Adjust for 0-based index
                    break; // Exit loop once valid input is given
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid goal number.");
                }
            }

            // Record the event for the selected goal
            goals[goalIndex].RecordEvent();
            Console.WriteLine("Event recorded successfully!");
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
        }

        static void DisplayGoals()
        {
            Console.Clear();
            if (goals.Count == 0)
            {
                Console.WriteLine("No goals have been created yet.");
                return;
            }

            Console.WriteLine("Your Goals:");
            Console.WriteLine("====================");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].Name}");
                goals[i].DisplayGoal();
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
        }

        static void DisplayScore()
        {
            Console.Clear();
            if (goals.Count == 0)
            {
                Console.WriteLine("No goals have been created yet. Score is 0.");
                Console.WriteLine("Press any key to return to the menu.");
                Console.ReadKey();
                return;
            }

            totalScore = 0;  // Reset total score and recalculate it based on all goals
            foreach (var goal in goals)
            {
                totalScore += goal.GetScore();  // Get the total score for each goal
            }

            Console.WriteLine($"Your current score: {totalScore}");
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
        }
    }
}
