namespace StudentGradeManagement;

public class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    private List<double> Grades { get; set; } = new List<double>();

    public void AddGrade(double grade)
    {
        Grades.Add(grade);
    }

    public void AddGrade(params double[] grades)
    {
        Grades.AddRange(grades);
    }

    public double CalculateAverageGrade()
    {
        double reportCard = 0;
        foreach (var grade in Grades)
        {
            reportCard += grade;
        }

        return reportCard / Grades.Count;
    }
}