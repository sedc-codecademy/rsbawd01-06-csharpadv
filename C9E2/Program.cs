using System;

namespace C9E2
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Alice", Age = 22, GPA = 3.8 },
                new Student { Name = "Bob", Age = 18, GPA = 3.2 },
                new Student { Name = "Charlie", Age = 20, GPA = 3.9 },
                new Student { Name = "David", Age = 24, GPA = 3.7 },
                new Student { Name = "Eve", Age = 19, GPA = 4.0 },
                new Student { Name = "Frank", Age = 25, GPA = 3.5 },
                new Student { Name = "Grace", Age = 21, GPA = 3.6 },
                new Student { Name = "Helen", Age = 18, GPA = 3.8 },
                new Student { Name = "Ivy", Age = 26, GPA = 3.9 },
                new Student { Name = "Jack", Age = 22, GPA = 3.2 },
                new Student { Name = "Katherine", Age = 23, GPA = 3.4 },
                new Student { Name = "Liam", Age = 19, GPA = 3.9 },
                new Student { Name = "Mia", Age = 20, GPA = 3.7 },
                new Student { Name = "Nathan", Age = 24, GPA = 3.8 },
                new Student { Name = "Olivia", Age = 22, GPA = 3.5 },
                new Student { Name = "Peter", Age = 18, GPA = 3.1 },
                new Student { Name = "Quinn", Age = 20, GPA = 3.6 },
                new Student { Name = "Rachel", Age = 21, GPA = 3.9 },
                new Student { Name = "Samuel", Age = 25, GPA = 3.2 },
                new Student { Name = "Taylor", Age = 24, GPA = 3.8 },
                new Student { Name = "Uma", Age = 19, GPA = 3.4 },
                new Student { Name = "Vincent", Age = 23, GPA = 3.7 },
                new Student { Name = "Wendy", Age = 22, GPA = 3.3 },
                new Student { Name = "Xavier", Age = 20, GPA = 3.8 },
                new Student { Name = "Yasmine", Age = 18, GPA = 3.5 },
                new Student { Name = "Zane", Age = 22, GPA = 3.9 }
            };

            // Exercise 1: Filtering and Ordering
            Console.WriteLine("Exercise 1: Filtering and Ordering\n");

            // Find all students who are at least 20 years old, ordered alphabetically by name.
            List<Student> studentsAbove20Ordered = students
                .Where(student => student.Age >= 20)
                .OrderBy(student => student.Name)
                .ToList();

            foreach (Student student in studentsAbove20Ordered)
                Console.WriteLine($"{student.Name}, Age: {student.Age}, GPA: {student.GPA}");

            Console.WriteLine("__________________________________________________________");

            // Exercise 2: Selecting Properties
            Console.WriteLine("Exercise 2: Selecting Properties\n");

            // Create a list of anonymous objects containing student names and their GPAs.
            var studentNameAndGPA = students
                .Select(student => new { student.Name, student.GPA })
                .ToList();

            foreach (var student in studentNameAndGPA)
                Console.WriteLine($"{student.Name}, GPA: {student.GPA}");

            // Display the top 3 students with the highest GPAs.
            var top3StudentsByGPA = studentNameAndGPA
                .OrderByDescending(student => student.GPA)
                .Take(3);

            Console.WriteLine("Top 3 students by GPA:");
            foreach (var student in top3StudentsByGPA)
                Console.WriteLine($"{student.Name}, GPA: {student.GPA}");

            Console.WriteLine("__________________________________________________________");

            // Exercise 3: Finding Extremes
            Console.WriteLine("Exercise 3: Finding Extremes\n");

            // Find the youngest student's name and age.
            Student youngestStudent = students
                .OrderBy(student => student.Age)
                .FirstOrDefault();

            Console.WriteLine($"Youngest student: {youngestStudent.Name}, Age: {youngestStudent.Age}");

            // Find the student with the highest GPA and their name.
            Student? highestGPAStudent = students
                .OrderByDescending(student => student.GPA)
                .FirstOrDefault();

            Console.WriteLine($"Highest GPA student: {highestGPAStudent.Name}, GPA: {highestGPAStudent.GPA}");

            Console.WriteLine("__________________________________________________________");

            // Exercise 4: Averaging GPA
            Console.WriteLine("Exercise 4: Averaging GPA\n");

            // Calculate and display the average GPA of all students.
            double averageGPA = students.Average(student => student.GPA);
            Console.WriteLine($"Average GPA: {averageGPA:F2}");

            Console.WriteLine("__________________________________________________________");

            // Exercise 5: Students by Age Range
            Console.WriteLine("Exercise 5: Students by Age Range\n");

            // Group students into age ranges: 15-19, 20-24, 25-29, and 30+.
            List<IGrouping<string, Student>> studentsByAgeRange = students
                .GroupBy(student =>
                {
                    if (student.Age >= 15 && student.Age <= 19) return "15-19";
                    if (student.Age >= 20 && student.Age <= 24) return "20-24";
                    if (student.Age >= 25 && student.Age <= 29) return "25-29";
                    return "30+";
                })
                .ToList();

            foreach (IGrouping<string, Student> group in studentsByAgeRange)
            {
                Console.WriteLine($">>> Group Age: {group.Key}");

                foreach (Student student in group)
                    Console.WriteLine($"    {student.Name}, Age: {student.Age}");

                Console.WriteLine("-----------------------------------------------");
            }

            Console.WriteLine("__________________________________________________________");

            // Exercise 6: Students with Specific GPA Range
            Console.WriteLine("Exercise 6: Students with Specific GPA Range\n");

            // Find students with a GPA between 3.5 and 4.0.
            List<Student> studentsWithSpecificGPARange = students
                .Where(student => student.GPA >= 3.5 && student.GPA <= 4.0)
                .ToList();

            foreach (Student student in studentsWithSpecificGPARange)
                Console.WriteLine($"{student.Name}, GPA: {student.GPA}");

            Console.WriteLine("__________________________________________________________");

            Console.WriteLine("Exercise 7: Top 3 Oldest Students\n");

            // Find the top 3 oldest students and display their names and ages.
            List<Student> top3OldestStudents = students
                .OrderByDescending(student => student.Age)
                .Take(3)
                .ToList();

            Console.WriteLine("Top 3 oldest students:");

            foreach (Student student in top3OldestStudents)
                Console.WriteLine($"{student.Name}, Age: {student.Age}");

            Console.WriteLine("__________________________________________________________");

            Console.WriteLine("Exercise 8: Students with Same Age\n");

            // Group students by age and list the students within each age group.
            List<IGrouping<int, Student>> studentsByAgeGroup = students
                .GroupBy(student => student.Age)
                .ToList();

            foreach (IGrouping<int, Student> group in studentsByAgeGroup)
            {
                Console.WriteLine($"Age: {group.Key}");

                foreach (Student student in group)
                    Console.WriteLine($"{student.Name}");
            }

            Console.WriteLine("__________________________________________________________");

            Console.WriteLine("Exercise 9: Students with Unique First Names\n");

            // Find students with unique first names and display their names.
            IEnumerable<Student> uniqueFirstNames = students
                .GroupBy(student => student.Name.Split()[0]) // Assuming first name is the first part of the full name
                .Where(group => group.Count() == 1)
                .SelectMany(group => group);

            Console.WriteLine("Students with unique first names:");

            foreach (Student? student in uniqueFirstNames)
                Console.WriteLine($"{student.Name}");

            Console.WriteLine("__________________________________________________________");

            Console.WriteLine("Exercise 10: Students by GPA Range and Order\n");

            // Select students with a GPA between 3.0 and 3.5, ordered by GPA in descending order.
            List<Student> studentsByGPARangeAndOrder = students
                .Where(student => student.GPA >= 3.0 && student.GPA <= 3.5)
                .OrderByDescending(student => student.GPA)
                .ToList();

            Console.WriteLine("Students with GPA between 3.0 and 3.5, ordered by GPA:");
           
            foreach (Student student in studentsByGPARangeAndOrder)
                Console.WriteLine($"{student.Name}, GPA: {student.GPA}");

        }
    }
}