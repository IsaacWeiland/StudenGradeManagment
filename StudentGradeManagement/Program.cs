using StudentGradeManagement;

List<Student> students = new List<Student>();
var thomas = new Student()
{
    Name = "Thomas",
    ID = 5535
};
students.Add(thomas);
var henry = new Student()
{
    Name = "Henry",
    ID = 4490
};
students.Add(henry);
var diana = new Student()
{
    Name = "Diana",
    ID = 6129
};
students.Add(diana);
var george = new Student()
{
    Name = "George",
    ID = 5555
};
students.Add(george);
thomas.AddGrade(70.5);
thomas.AddGrade(80.4, 90.6, 79.9);
henry.AddGrade(99.5);
henry.AddGrade(90.5, 89.1, 85.9);
diana.AddGrade(85.9);
diana.AddGrade(75.9, 80.9, 90.7);
george.AddGrade(100);
george.AddGrade(100, 100, 100);
foreach (var student in students)
{
    Console.WriteLine($"Student: {student.Name}\nID: {student.ID}");
    Console.WriteLine($"Grade Average:{student.CalculateAverageGrade()}");
}