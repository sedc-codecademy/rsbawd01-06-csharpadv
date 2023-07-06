namespace AbstractClasses.Models
{
    public class Developer : Human, IPerson
    {
        public List<string> Skills { get; set; }
        public int YearsOfExperience { get; set; }

        public string PassportNumber { get; set; }

        public Developer(string fullName, int age, DateTime dob) 
            : base(fullName, age, dob)
        {
            Skills = new List<string>();
        }

        public override string GetInfo()
        {
           return $"I DEVELOPER am {FullName}, and I have {YearsOfExperience} years of experience!";
        }

        public void GetInfoExtra() 
        {
        
        }
    }
}
