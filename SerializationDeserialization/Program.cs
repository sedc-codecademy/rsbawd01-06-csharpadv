using Newtonsoft.Json;
using SerializationDeserialization.Models;
using System.Diagnostics.CodeAnalysis;

namespace SerializationDeserialization
{
    internal class Program
    {
        static void Main()
        {
            Student student = new Student()
            {
                FirstName = "Almir",
                IsPartTime = true,
                Age = 28,
                LastName = "Vuk",
                Grade = "10"
            };

            string json = SerializeStudent(student);

            Console.WriteLine("JSON Content: ");
            Console.WriteLine(json);

            string jsonWithLibrary = SerializeStudentWithLibrary(student);

            Console.WriteLine("JSON Content with Library: ");
            Console.WriteLine(jsonWithLibrary);

            Console.WriteLine("Student object after deserialization: ");

            Student almirDeserialized = DeserializeStudentWithLibrary(jsonWithLibrary);

            Console.WriteLine($"{almirDeserialized.FirstName} - {almirDeserialized.LastName}" +
                $"{almirDeserialized.Age} - {almirDeserialized.IsPartTime} - " +
                $"{almirDeserialized.Grade}");
        }

        private static string SerializeStudent(Student student)
        {
            /*
                {
                    "FirstName" : "Neka vrijednost",
                    "LastName" : "Neka vrijednost",
                    "Age": 26,
                    "IsPartTime" : true or false
                }
             */

            string json = "{";

            json += $"\"FirstName\" : \"{student.FirstName}\",";
            json += $"\"LastName\" : \"{student.LastName}\",";
            json += $"\"Age\" : \"{student.Age}\",";
            json += $"\"IsPartTime\" : \"{student.IsPartTime.ToString().ToLower()}\"";

            json += "}";

            return json;
        }

        private static string SerializeStudentWithLibrary(Student student)
        {
            return JsonConvert.SerializeObject(student);
        }

        private static Student DeserializeStudent(string json)
        {
            // Cleaning the json
            string content = json
                .Substring(json.IndexOf("{") + 1, json.IndexOf("}") - 1)
                .Replace("\r", "")
                .Replace("\n", "")
                .Replace("\"", "");

            string[] properties = content.Split(',');

            // Creating dictionary with clean keys( properties ) and values
            Dictionary<string, string> propertiesDictionary =
                new Dictionary<string, string>();

            foreach (string property in properties)
            {
                string[] pair = property.Split(':');
                propertiesDictionary.Add(pair[0].Trim(), pair[1].Trim());
            }

            // Creating a Student object with the values from the dictionary
            Student student = new Student();
            student.FirstName = propertiesDictionary["FirstName"];
            student.LastName = propertiesDictionary["LastName"];
            student.Age = int.Parse(propertiesDictionary["Age"]);
            student.IsPartTime = bool.Parse(propertiesDictionary["IsPartTime"]);

            return student;
        }

        private static Student DeserializeStudentWithLibrary(string json)
        {
            Student studentDeserialized = JsonConvert.DeserializeObject<Student>(json);

            return studentDeserialized;
        }
    }
}