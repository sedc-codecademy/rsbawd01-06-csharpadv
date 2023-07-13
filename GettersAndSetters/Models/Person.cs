namespace GettersAndSetters.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int _age;
        public int Age 
        {
            get { return _age; }
            set 
            {
                if (value < 0)
                    throw new ArgumentException("Age can not be lower than zero");
                
                _age = value;
            }
        }
        
    }
}
