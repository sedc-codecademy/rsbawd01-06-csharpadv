using System;
using System.Collections.Generic;
using System.Linq;
namespace AbstractClasses.Models
{
    public class QAEngineer : Human
    {
        public bool IsAutomationTester { get; set; }

        public QAEngineer(string fullName, int age, DateTime dob) 
            : base(fullName, age, dob)
        {
        }

        public override string GetInfo()
        {
            string info = $"I am QAEngineer {FullName}, and";

            if (IsAutomationTester)
                info += " automation tester";
            else
                info += " manual tester";

            return info;
        }
    }
}
