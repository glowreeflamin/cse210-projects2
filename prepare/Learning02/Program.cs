using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job(); // Instantiate and initialize the Job object
        job1._jobTitle = "Software Engineering";
        job1._company = "Microsoft"; 
        job1._startYear = 2020;
        job1._endYear = 2024;

        job1.DisplayInfo(); // Call the Display method to show job details
    }
}