using System;

public enum AcademicDepartment
{
    Science,
    Arts,
    Commerce,
    Engineering,
    Medicine
}

public class Individual
{
    private string fullName;

    public Individual()
    {
        fullName = null;
    }

    public Individual(string fullName)
    {
        this.fullName = fullName;
    }

    public string FullName
    {
        get { return fullName; }
        set { fullName = value; }
    }
}

public class Learner : Individual
{
    private string studentId;
    private int studentAge;
    private AcademicDepartment major;

    public Learner() : base()
    {
        studentId = null;
        studentAge = 0;
        major = default(AcademicDepartment);
    }

    public Learner(string fullName, string studentId, int studentAge, AcademicDepartment major) : base(fullName)
    {
        this.studentId = studentId;
        this.studentAge = studentAge;
        this.major = major;
    }

    public string StudentId
    {
        get { return studentId; }
        set { studentId = value; }
    }

    public int StudentAge
    {
        get { return studentAge; }
        set { studentAge = value; }
    }

    public AcademicDepartment Major
    {
        get { return major; }
        set { major = value; }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Learner learner1 = new Learner();
        learner1.FullName = "Abdullah";
        learner1.StudentId = "233577";
        learner1.StudentAge = 19;
        learner1.Major = AcademicDepartment.Engineering;

        Learner learner2 = new Learner("Aysha", "233560", 22, AcademicDepartment.Science);

        Console.WriteLine("Learner 1:");
        PrintLearnerDetails(learner1);

        Console.WriteLine("\nLearner 2:");
        PrintLearnerDetails(learner2);
    }

    public static void PrintLearnerDetails(Learner learner)
    {
        Console.WriteLine($"Full Name: {learner.FullName}");
        Console.WriteLine($"Student ID: {learner.StudentId}");
        Console.WriteLine($"Age: {learner.StudentAge}");
        Console.WriteLine($"Major: {learner.Major}");
    }
}