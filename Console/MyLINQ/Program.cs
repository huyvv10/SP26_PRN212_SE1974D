using System.Reflection;
using System.Xml.Linq;
using MyLINQ;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { Id=1, Name="An", Age=20, Gender="Male", DepartmentId=1, GPA=3.2 },
            new Student { Id=2, Name="Mai", Age=21, Gender="Female", DepartmentId=1, GPA=3.8 },
            new Student { Id=3, Name="Chi", Age=19, Gender="Female", DepartmentId=2, GPA=2.9 },
            new Student { Id=4, Name="Dung", Age=22, Gender="Male", DepartmentId=2, GPA=3.5 },
            new Student { Id=5, Name="Huy", Age=20, Gender="Male", DepartmentId=3, GPA=3.9 }
        };

        List<Department> departments = new List<Department>
        {
            new Department { Id=1, Name="Software Engineering" },
            new Department { Id=2, Name="Information Systems" },
            new Department { Id=3, Name="Artificial Intelligence" }
        };

        List<Course> courses = new List<Course>
        {
            new Course { Id=1, Name="PRN212", Credits=3 },
            new Course { Id=2, Name="CSD201", Credits=4 },
            new Course { Id=3, Name="DIB202", Credits=3 }
        };

        List<Enrollment> enrollments = new List<Enrollment>
        {
            new Enrollment { StudentId=1, CourseId=1, Score=8.0 },
            new Enrollment { StudentId=1, CourseId=2, Score=7.5 },
            new Enrollment { StudentId=2, CourseId=1, Score=9.0 },
            new Enrollment { StudentId=3, CourseId=3, Score=6.0 },
            new Enrollment { StudentId=4, CourseId=2, Score=8.5 },
            new Enrollment { StudentId=5, CourseId=1, Score=9.5 }
        };

        //Query Expression
        List<int> NumList = new List<int> { 17, 12, 11, 4, 9, 6, 8 };
        var evenNum = from i
                      in NumList
                      where i%2==0
                      select i;
        foreach (var e in evenNum)
        {
            Console.Write(e+ " ");
        }

        List<string> strings = new List<string>() {"Cong", "Hoa", "Xa", "Hoi", "Chu", "Nghia" };
        var ss = from s in strings
                 where s.Contains("H")
                 select s;
        Console.WriteLine();
        foreach (var e in ss)
        {
            Console.Write(e + " ");
        }

        //Properties query
        //1. WHERE (filter)
        //Get all student with GPA>=3.5
        Console.WriteLine("\n\n1. Get all student with GPA>=3.5");
        var s1 = students.Where (s => s.GPA>=3.5).ToList();
        Console.WriteLine($"{"Id",-5} {"Name",-10} {"Age",-5} {"Gender",-7} {"DepartmentId",-13} {"GPA",5}");        Console.WriteLine($"{"--",-5} {"----",-10} {"---",-5} {"------",-7} {"----------",-13} {"---",5}");
        foreach (var e in s1)
        {
            e.displayStudent();
        }

        //Get all Female students
        Console.WriteLine("\n2. Get all female students");
        var s2 = students.Where(s => s.Gender=="Female").ToList();
        foreach (var e in s2)
        {
            e.displayStudent();
        }

        //Get all male with GPA>=3.5
        Console.WriteLine("\n3. Get all male with GPA>=3.5");
        var s3 = students.Where(s => s.Gender == "Male" 
                                && s.GPA>=3.5)
                         .ToList();
        foreach (var e in s3)
        {
            e.displayStudent();
        }

        //2. SELECT
        Console.WriteLine("\n4. Get all student names");
        var s4 = students.Select(s => s.Name).ToList();
        foreach(var e in s4)
        {
            Console.Write($"{e} ");
        }
        Console.WriteLine();

        Console.WriteLine("\n5. Get all student names are male with GPA>=5");
        var s5 = students.Where(s => s.Gender == "Male"
                                && s.GPA >= 3.5)
                         .Select(s => s.Name)
                         .ToList();

        foreach (var e in s5)
        {
            Console.Write($"{e} ");
        }
        Console.WriteLine();

        Console.WriteLine("\n6. Get Id, Name, GPA");
        var s6 = students.Select(s => new {s.Id, s.Name, s.GPA})
                        .ToList();

        foreach (var e in s6)
        {
            Console.WriteLine($"{e.Id,-5} {e.Name,-10} {e.GPA,5:F2}");
        }

        //3. OrderBy/ThenBy (for sorting)
        Console.WriteLine("\n7. Sort by Age in ASC");
        var s7 = students.OrderBy(s => s.Age).ToList();
        foreach (var e in s7)
        {
            e.displayStudent();
        }

        Console.WriteLine("\n8. Sort by Age in ASC then by GPA in Desc");
        var s8 = students.OrderBy(s => s.Age)
                .ThenByDescending(s => s.GPA)
                .ToList();
        foreach (var e in s8)
        {
            e.displayStudent();
        }


        //4. GroupBy
        var s9 = students.GroupBy(s => s.DepartmentId)
                         .Select(g => new { g.Key, Count = g.Count() });

        foreach (var e in s9)
        {
            Console.WriteLine($"{e.Key,-5} {e.Count}");
        }

        //5. Aggregation Count, Sum, Max, Min, Average
        var s10 = students.Count();
        Console.WriteLine($"\n10. Number of students: {s10}");

        //Count number of students with their age between [19, 21]
        var s11 = students.Where(s => s.Age >= 19 && s.Age <= 21)
                          .Count();
        Console.WriteLine($"\n11. Number of students: {s11}");

        //6. All/Any

        //7. Join
        var s12 = students.Join(departments,
            s => s.DepartmentId,   
            d => d.Id,
            (s,d) => new { s.Name, DepartmentName= d.Name }).ToList();

        foreach(var e in s12)
        {
            Console.WriteLine($"{e.Name,-5} {e.DepartmentName,30}");
        }

    }

}