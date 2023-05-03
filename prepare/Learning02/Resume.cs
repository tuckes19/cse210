public class Resume{

// instances
public string _name;
public List<Job> _job = new List<Job>();

// constructor
public Resume(){

}

// methods
public void DisplayResumeDetails(){

Console.WriteLine($"Name: {_name}");
Console.WriteLine("Jobs:");

foreach (Job job in _job){
    
    job.DisplayJobDetails();

}
}

}