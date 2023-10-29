using İnterface_Abstract_HomeWork.Models;

namespace İnterface_Abstract_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle teyyare = new Plane()
            {
                IdCode = "x001",
                DriveTime = 2,
                DrivePath = 200,
                HorsePower = 70,
                CurrentOil = 5,
                FuelType = "Dizel",
                TankSize = 40,
                WingLenth = 20,
            };
            Vehicle velo = new Bicycle()
            {
                IdCode = "x002",
                DriveTime = 2,
                DrivePath = 200,
                PedalKind = "hybrid",
                TransmissionKind = "Manual",
                WheelThickness = 15

            };
            Vehicle masin = new Car()
            {
                IdCode = "x003",
                DoorCount = 2,
                WinCode = "a23d5as2w",
                DriveTime = 2,
                DrivePath = 200,
                HorsePower = 70,
                CurrentOil = 5,
                FuelType = "Dizel",
                WheelThickness = 30,
                TransmissionKind = "Manual",
                TankSize = 40,
            };
            methods method = new methods();
            method.AddVehicle((Vehicle)masin);
            method.AddVehicle((Vehicle)velo);
            method.AddVehicle((Vehicle)teyyare);
            method.GetInfo(method.Vehicles[0]);
            method.GetInfo(method.Vehicles[1]);
            method.GetInfo(method.Vehicles[2]);




        }
    }

}