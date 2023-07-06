namespace AbstractClasses.Models
{
    public abstract class Human
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }

        public Human(string fullName, int age, DateTime dob)
        {
            FullName = fullName;
            Age = age;
            DOB = dob;
        }

        public abstract string GetInfo();

        public void SayHello(string name) 
        {
            Console.WriteLine($"Hi {name}, I am human class and my name is {FullName}");
        }
    }
}
