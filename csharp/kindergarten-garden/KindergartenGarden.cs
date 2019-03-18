using System;
using System.Collections.Generic;
using System.Linq;

    public enum Plant
    {
        Violets = 86,
        Radishes = 82,
        Clover = 67,
        Grass = 71
    }

    public struct Student
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public List<Plant> Plants { get; set; }
    }


public class KindergartenGarden
{
    private List<Student> students = new List<Student>
    {
         new Student{Name = "Alice", ID = 0, Plants = new List<Plant>()},
         new Student{Name = "Bob", ID = 1, Plants = new List<Plant>()  },
         new Student{Name = "Charlie", ID = 2, Plants = new List<Plant>() },
         new Student{Name = "David", ID = 3,  Plants = new List<Plant>() },
         new Student{Name = "Eve", ID = 4 , Plants = new List<Plant>() },
         new Student{Name = "Fred", ID = 5 , Plants = new List<Plant>() },
         new Student{Name = "Ginny", ID = 6, Plants = new List<Plant>()  },
         new Student{Name = "Harriet", ID = 7, Plants = new List<Plant>()  },
         new Student{Name = "Ileana", ID = 8, Plants = new List<Plant>()  },
         new Student{Name = "Joseph", ID = 9, Plants = new List<Plant>()  },
         new Student{Name = "Kincaid", ID = 10, Plants = new List<Plant>()  },
         new Student{Name = "Larry", ID = 11, Plants = new List<Plant>()  },
    };
    public KindergartenGarden(string diagram)
    {
        string firstRow = String.Concat(diagram.Take(((diagram.Length - 1) / 2)));
        string secondRow = String.Concat(diagram.Substring((diagram.Length + 1) / 2, (diagram.Length - 1) / 2));

        AssignPlants(firstRow);
        AssignPlants(secondRow);
    }

    private void AssignPlants(string row)
    {
        int currentStudentId = 0;

        for (int i = 0; i < row.Length; i++)
        {
            if (i % 2 == 0 && i != 0)
            {
                currentStudentId++;
            }
            students[currentStudentId].Plants.Add((Plant)row[i]);
        }
    }

    public IEnumerable<Plant> Plants(string student)
    {
        return students.Where(s => s.Name == student).Select(s => s.Plants).First();
    }
}