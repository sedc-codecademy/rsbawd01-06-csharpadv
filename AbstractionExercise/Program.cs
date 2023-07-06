namespace AbstractionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Student objects
            Student student1 = new Student
            {
                Id = 1,
                Name = "John Smith",
                Username = "johns",
                Password = "password123",
                Grades = "A"
            };

            Student student2 = new Student
            {
                Id = 2,
                Name = "Jane Doe",
                Username = "janed",
                Password = "pass123",
                Grades = "B"
            };

            // Create Teacher objects
            Teacher teacher1 = new Teacher
            {
                Id = 101,
                Name = "Mr. Johnson",
                Username = "johnsonm",
                Password = "teacher123",
                Subject = "Math"
            };

            Teacher teacher2 = new Teacher
            {
                Id = 102,
                Name = "Mrs. Anderson",
                Username = "andersonm",
                Password = "teacher456",
                Subject = "Science"
            };

            // Call PrintUser() on all objects
            student1.PrintUser();
            Console.WriteLine();

            student2.PrintUser();
            Console.WriteLine();

            teacher1.PrintUser();
            Console.WriteLine();

            teacher2.PrintUser();
        }
    }
}