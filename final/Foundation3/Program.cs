using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("8138 Spearman Road", "Browns Summit", "NC", "USA");
        Address address2 = new Address("2645 Fox Creek Drive", "Lima", "OH", "USA");
        Address address3 = new Address("1265 Lombardi Avenue", "Green Bay", "WI", "USA");

        Lecture lecture = new Lecture("Lecture", "Big-boy Lecture", "A lecture for big-boys", "June 19, 2023", 1900, address1, "Seth Tucker", 37);
        Reception reception = new Reception("Reception", "Seth's Wedding Reception", "Celebrate Seth's marriage", "December 19, 2024", 1700, address2, "thesethtucker@gmail.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Outdoor Gathering", "Packers vs. Bears", "Exciting football game!", "December 7, 2023", 1400, address3, "25 degrees with snow flurries expected");

        lecture.ListStandardDetails();
        lecture.ListFullDetails();
        lecture.ListShortDescription();

        reception.ListStandardDetails();
        reception.ListFullDetails();
        reception.ListShortDescription();

        outdoorGathering.ListStandardDetails();
        outdoorGathering.ListFullDetails();
        outdoorGathering.ListShortDescription();
    }
}