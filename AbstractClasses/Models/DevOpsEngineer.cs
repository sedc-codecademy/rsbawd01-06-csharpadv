namespace AbstractClasses.Models
{
    public class DevOpsEngineer : Human, IPerson
    {
        public bool IsMicrosoftCertified { get; set; }
        public bool IsAmazonCertified { get; set; }
        public string PassportNumber { get; set; }

        public DevOpsEngineer(string fullName, int age, DateTime dob) 
            : base(fullName, age, dob)
        {
        }

        public override string GetInfo()
        {
            string info = $"I am DevOps Engineer, {FullName} and I am certified in: ";

            if (IsMicrosoftCertified)
                info += " Microsoft.";

            if (IsAmazonCertified)
                info += " Amazon.";

            return info;
        }
    }
}
