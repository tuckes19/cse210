using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "National Football League";
        job1._jobTitle = "Wide Receiver";
        job1._startYear = 2010;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._company = "Deseret Industries";
        job2._jobTitle = "General Associate";
        job2._startYear = 2022;
        job2._endYear = 2023;

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        resume1._name = "Seth Tucker";

        resume1._job.Add(job1);
        resume1._job.Add(job2);

        resume1.DisplayResumeDetails();

    }
}