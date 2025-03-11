using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables
    public string _name;
    public List<Job> _jobs = new List<Job>(); // Initialize list of jobs

    // Display method
    public void Display()
    {
        Console.WriteLine($"Resume of: {_name}");
        Console.WriteLine("Jobs:");
        
        foreach (Job job in _jobs)
        {
            job.Display(); // Call Display method from Job class
        }
    }
}
