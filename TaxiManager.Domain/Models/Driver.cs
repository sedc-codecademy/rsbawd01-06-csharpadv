namespace TaxiManager.Domain
{
    public class Driver : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Shift Shift { get; set; }

        public Car Car { get; set; }
        public string License { get; set; }
        public DateTime LicenseExpieryDate { get; set; }

        public string FullName => FirstName + " " + LastName;

        public Driver() { }

        public Driver(string firstName, string lastName, Shift shift, Car car, string license, DateTime expieryDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Shift = shift;
            Car = car;
            License = license;
            LicenseExpieryDate = expieryDate;

        }

        public override string Print()
        {
            string model = Car == null ? "/" : Car.Model;
            return $"{FullName} Driving in the {Shift} shift with a {model} car";
        }

        public ExpieryStatus IsLicenseExpired()
        {
            if (DateTime.Today >= LicenseExpieryDate) return ExpieryStatus.Expired;
            else if (DateTime.Today.AddMonths(3) >= LicenseExpieryDate) return ExpieryStatus.Warning;
            else return ExpieryStatus.Valid;
        }
    }
}
