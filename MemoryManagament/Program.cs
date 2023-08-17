using System.Data.SqlTypes;

namespace MemoryManagament
{
    internal class Program
    {
        static void Main()
        {
            Student student = new Student();

            student.FirstName = "Zoran";
            student.LastName = "Malinovic";

            Console.WriteLine($"{student.FirstName} {student.LastName}");

            Console.WriteLine("Before: Student student2 = student");

            Student student2 = student;
            student2.LastName = "MALINOVIC VELIKA SLOVA 2222222";

            Console.WriteLine($"{student.FirstName} {student.LastName}");
            Console.WriteLine($"{student2.FirstName} {student2.LastName}");

            student.FirstName = "YORAN";

            Console.WriteLine("After izmjena");

            Console.WriteLine($"{student.FirstName} {student.LastName}");
            Console.WriteLine($"{student2.FirstName} {student2.LastName}");

            student2 = new Student();

            Console.WriteLine("After: student2 = new Student();");

            student2.FirstName = "Almir";
            student2.LastName = "Vuk";

            string sadrya = $"{student2.FirstName} {student2.LastName}";

            Console.WriteLine($"{student.FirstName} {student.LastName}");
            Console.WriteLine(sadrya);

            Student student3 = student2;

            student = null;
            student2 = null;

            student2 = new Student();

            Console.WriteLine("Student3:");
            Console.WriteLine($"{student3.FirstName} {student3.LastName}");

            Console.WriteLine(".....................................................");

            string path = "novifajl.txt";

            if (File.Exists(path) == false)
                File.Create(path).Close();

            OurTextWriter ourTextWriter = new OurTextWriter(path);

            using (ourTextWriter)
            {
                ourTextWriter.Write("Nova linija");
                ourTextWriter.Write("Nova linija");
            }
        }
    }
}