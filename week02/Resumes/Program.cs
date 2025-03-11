using System;

class Program
{
    static void Main(string[] args)
     {
        // Create first job
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";  
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Create second job
        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Apple";  
        job2._startYear = 2017;
        job2._endYear = 2021;

        // Create Resume instance
        Resume myResume = new Resume();
        myResume._name = " Allison Rose"; // Assign a name to the resume

        // Add jobs to resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display resume details
        myResume.Display();
    }
}
