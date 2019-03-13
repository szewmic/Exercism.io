using System;
using System.Collections.Generic;
using System.Text;

public class Robot
{
    public static HashSet<String> usedNames = new HashSet<string>();
    public static Random drawer = new Random();

    private string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        private set
        {
            _name = value;
        }
    }

    public Robot()
    {
        Name = DrawName();
    }
    public void Reset()
    {
        string temp = this.Name;

        Name = DrawName();
        usedNames.Remove(temp);
    }

    public static String DrawName()
    {
        StringBuilder builder = new StringBuilder(5);

        String name;
        do
        {
            builder.Clear();

            name = builder.AppendFormat("{0}{1}{2}{3}{4}",
                (char)drawer.Next(65, 91),
                (char)drawer.Next(65, 91),
                drawer.Next(0, 10),
                drawer.Next(0, 10),
                drawer.Next(0, 10)
                ).ToString();

        } while (usedNames.Contains(name));


        usedNames.Add(name);
        return name;
    }
}