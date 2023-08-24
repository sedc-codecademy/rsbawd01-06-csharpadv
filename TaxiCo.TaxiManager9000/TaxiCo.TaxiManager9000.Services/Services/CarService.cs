using TaxiManager9000.Domain;

namespace TaxiManager9000.Services
{
    public class CarService : ServiceBase<Car>, ICarService
    {
        public bool IsAvailableCar(Car car)
        {
            return car.IsLicenseExpired() == ExpieryStatus.Expired || car.DriversAssigned.Count == 3 ? false : true;
        }
    }
}
