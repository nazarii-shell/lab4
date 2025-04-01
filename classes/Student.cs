namespace lab4.classes;

public class Student
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public double Score { get; set; }
    public int Group { get; set; }

    public Student(string lastName, string firstName, double score, int group)
    {
        LastName = lastName;
        FirstName = firstName;
        Score = score;
        Group = group;
    }

    public override string ToString()
    {
        return FirstName + " " + LastName + "; Score: " + Score + "; Group:" + Group; ;
    }
    
}