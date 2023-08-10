namespace C9E1
{
    internal class Program
    {
        static void Main()
        {
            string filePath = CreateFile();

            string userExitChoice = "Y";

            do
            {
                // Menu
                Console.WriteLine("Students Record Managament\n..........................");
                Console.WriteLine("1.Add a new student record\n2.Display all students\n3.Search by name\n4.Exit");

                Console.Write("\n\nEnter your choice: ");

                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:

                        AddNewStudent(filePath);
                        userExitChoice = UserExitControl();

                        break;

                    case 2:

                        ShowAllRecords(filePath);
                        userExitChoice = UserExitControl();

                        break;

                    case 3:

                        SearchByName(filePath);
                        userExitChoice = UserExitControl();

                        break;

                    case 4:
                        userExitChoice = "N";
                        break;

                }

            } while (userExitChoice == "Y");

            Console.WriteLine("Done running....");
        }

        private static string CreateFile()
        {
            // Get the file path
            string filePath = Directory.GetCurrentDirectory() + "\\Students.txt";

            // Check if the file exits and create if not
            if (File.Exists(filePath) == false)
                File.Create(filePath)
                    .Close();
            return filePath;
        }

        private static void SearchByName(string filePath)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(".................................");

            Console.Write("Enter student name to search: ");
            string searchContent = Console.ReadLine();

            StreamReader streamReader = new StreamReader(filePath);

            List<string> foundStudents = new List<string>();

            using (streamReader) 
            {
                string allStudents = streamReader.ReadToEnd();

                string[] studentsArr = allStudents.Split("\n");

                foreach (string student in studentsArr) 
                    if (student.Contains(searchContent))
                        foundStudents.Add(student);
            }


            Console.WriteLine("Student found:");
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (string found in foundStudents)
                Console.WriteLine(found);

            Console.WriteLine(".................................");
            Console.ResetColor();
        }

        private static void ShowAllRecords(string filePath)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(".................................");

            StreamReader streamReader = new StreamReader(filePath);

            using (streamReader) 
                Console.WriteLine(streamReader.ReadToEnd());

            Console.WriteLine(".................................");
            Console.ResetColor();
        }

        private static string UserExitControl()
        {
            string userExitChoice;
            Console.WriteLine("Do you want to continue? Y/N");
            userExitChoice = Console.ReadLine();
            Console.Clear();
            return userExitChoice;
        }

        private static void AddNewStudent(string filePath)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Enter student information (Name, Age, Grade): ");
            string userStudentInput = Console.ReadLine();

            StreamWriter streamWriter = new StreamWriter(filePath, true);

            using (streamWriter)
                streamWriter.WriteLine(userStudentInput);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Student record successfully added!");

            Console.ResetColor();
        }
    }
}