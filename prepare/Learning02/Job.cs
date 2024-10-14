using System;
using System.Collections.Generic;

public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    public void DisplayInfo() // Method to display the job details
    {
        Console.WriteLine($"{_jobTitle}, {_company},  {_startYear} - {_endYear}");
    }
}

