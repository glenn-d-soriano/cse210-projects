using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Resumes Project.");

        // Create Job instances
        Job job1 = new Job("Software Engineer", "Microsoft", 2019, 2022);
        Job job2 = new Job("Manager", "Apple", 2022, 2023);

        // Create Resume instance
        Resume myResume = new Resume("Glenn Soriano");

        // Add jobs to the resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        
        myResume.Display();
    }

    
}