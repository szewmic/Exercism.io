using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    struct Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
    }
    private List<Student> students = new List<Student>();
    public void Add(string student, int grade)
    {
        students.Add(new Student { Name = student, Grade = grade });
    }

    public IEnumerable<string> Roster()
    {
        return students.OrderBy(s=>s.Grade).ThenBy(s=>s.Name).Select(s=>s.Name);
    }

    public IEnumerable<string> Grade(int grade)
    {
        return students.Where(s => s.Grade == grade).Select(s=>s.Name).OrderBy(s=>s);
    }
}