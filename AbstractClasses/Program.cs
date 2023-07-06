using AbstractClasses.Models;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer("Zoran Malinovic", 35, new DateTime(1980, 1, 1));

            developer.YearsOfExperience = 25;
            developer.Skills.Add("C#");
            developer.Skills.Add(".NET");
            developer.Skills.Add("C++");
            developer.Skills.Add("Java");
            developer.PassportNumber = "0000000000000";

            DevOpsEngineer devOpsEngineer = new DevOpsEngineer("Almir Vuk", 28, new DateTime(1990, 1, 1));
            devOpsEngineer.IsMicrosoftCertified = true;
            devOpsEngineer.PassportNumber = "11111111111111";

            QAEngineer qAEngineer = new QAEngineer("Miroslav Popovic", 35, new DateTime(1980, 1, 1));
            qAEngineer.IsAutomationTester = true;

            PrintHumanInfo(developer);
            PrintHumanInfo(devOpsEngineer);
            PrintHumanInfo(qAEngineer);

            PrintPassportNumber(devOpsEngineer);
            PrintPassportNumber(developer);
        }

        public static void PrintHumanInfo(Human human) 
        {
            Console.WriteLine(human.GetInfo());
        }

        public static void PrintPassportNumber(IPerson person) 
        {
            Console.WriteLine($"Passport number: {person.PassportNumber}");
        }
    }
}