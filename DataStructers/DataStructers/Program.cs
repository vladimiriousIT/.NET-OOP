using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the file and build the hash-table of courses
            Dictionary<string, List<Student>> courses =
            new Dictionary<string, List<Student>>();
            StreamReader reader = new StreamReader("Students.txt",
            Encoding.GetEncoding("utf-8"));
            using (reader)
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] entry = line.Split(new char[] { '|' });
                    string firstName = entry[0].Trim();
                    string lastName = entry[1].Trim();
                    string course = entry[2].Trim();
                    List<Student> students;
                    if (!courses.TryGetValue(course, out students))
                    {
                        // New course -> create a list of students for it
                        students = new List<Student>();
                        courses.Add(course, students);
                    }
                    Student student = new Student(firstName, lastName);
                    students.Add(student);
                }
            }
            // Print the courses and their students
            foreach (string course in courses.Keys)
            {
                Console.WriteLine("Course " + course + ":");
                List<Student> students = courses[course];
                students.Sort();
                foreach (Student student in students)
                {
                    Console.WriteLine("\t{0}", student);
                }
            }
        }
    }
}
