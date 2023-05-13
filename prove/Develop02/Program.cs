using System;

class Program
{
    static void Main(string[] args)
    {
        Journal _journal = new Journal();
        Menu _menu = new Menu(_journal);
        _menu.Display();
    }
}

// I exceeded the requirements of the assignment by adding two other 
// pieces of info to save to the file. I made it so with each entry,
// the user submits what there overall emotion about their entry is as
// well as give the entry content a rating out of 10.