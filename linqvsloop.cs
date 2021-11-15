using System;
using System.Linq;
using System.Collections.Generic;

class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Student> studentArray = new List<Student>() { 
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
        };
		
		var studentTeenGodine = studentArray.OrderByDescending(s => s.Age);

        foreach (Student std in studentArray)
        {
            if (std.Age > 12 && std.Age < 20)
            {
                Console.WriteLine(std.StudentID + " " + std.StudentName + " " + std.Age);
            }
        }
		
    }
}