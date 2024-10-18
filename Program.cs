using System;
using System.Collections.Generic;

class VotingSystem
{
    // Dictionary to hold candidate names and their vote count
    static Dictionary<string, int> candidates = new Dictionary<string, int>()
    {
        {"ALICE", 0},
        {"BOB", 0},
        {"CHARLIE", 0}
    };

    static void Main()
    {
        bool running = true;

        Console.WriteLine("Simple Voting System\n");

        while (running)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Vote for a candidate");
            Console.WriteLine("2. View results");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice (1-3): ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CastVote();
                    break;
                case "2":
                    ViewResults();
                    break;
                case "3":
                    running = false;
                    Console.WriteLine("Exiting the system.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }
        }
    }

    // Function to cast a vote for a candidate
    static void CastVote()
    {
        Console.WriteLine("\nCandidates:");
        foreach (var candidate in candidates)
        {
            Console.WriteLine(candidate.Key);
        }

        Console.Write("Enter the name of the candidate you want to vote for: ");
        string vote = Console.ReadLine().ToUpper(); // Convert user input to uppercase

        // Check if the candidate exists in the dictionary (case insensitive)
        if (candidates.ContainsKey(vote))
        {
            candidates[vote]++;
            Console.WriteLine($"Vote casted for {vote}.");
        }
        else
        {
            Console.WriteLine("Invalid candidate name. Try again.");
        }
    }

    // Function to display voting results
    static void ViewResults()
    {
        Console.WriteLine("\nVoting Results:");
        foreach (var candidate in candidates)
        {
            Console.WriteLine($"{candidate.Key}: {candidate.Value} vote(s)");
        }
    }
}
