using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables
    public string _name;
    public List<Job> _jobs;

    // Constructor to initialize the name and job list
    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }

    // To add a job to the resume
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // To display the resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (var job in _jobs)
        {
            job.Display();
        }
    }
}


