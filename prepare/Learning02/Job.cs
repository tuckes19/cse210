public class Job {

// instances
public string _company;
public string _jobTitle;
public int _startYear;
public int _endYear;

// constructor
public Job(){

}

// methods
public void DisplayJobDetails(){
    Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
}

}