using İnterface_Abstract_HomeWork.Models;
using System.Threading.Channels;
using System.Xml.Linq;

namespace İnterface_Abstract_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // vaxtim az idi deye proplara set qoya bilmedim + yazdiqim variantda inputu istifadechi daxil etmir
            //list usstunde emeliyyatlar ucun yeni class yaratdim

            methods method = new methods();  
            string Id;
            bool iscontinue = true;
            while (iscontinue)
            {

                Console.WriteLine($"\n0: Create a Plane\n1: Create a Car\n2: Create a Bicycle\n3: Delete Vehichle\n4: See all Vehichle Id\n5: See Vehichle Info\n6: End\n");
                string a = Console.ReadLine();

                switch (a)
                {
                    case "0":
                        Console.WriteLine("Write vehicle Id      (yoxlamaq asand olsun deye her defe eyni melumaatlari ferqli id ile daxil etmek ucun bele eledim)");
                        Vehicle teyyare = new Plane()
                        {
                            IdCode = Console.ReadLine(),
                            DriveTime = 2,
                            DrivePath = 200,
                            HorsePower = 70,
                            CurrentOil = 5,
                            FuelType = "Dizel",
                            TankSize = 40,
                            WingLenth = 20,
                        };
                        method.AddVehicle((Vehicle)teyyare);

                        break;


                    case "1":
                        Console.WriteLine("Write vehicle Id   (yoxlamaq asand olsun deye her defe eyni melumaatlari ferqli id ile daxil etmek ucun bele eledim)");

                        Vehicle masin = new Car()
                        {
                            IdCode = Console.ReadLine(),
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
                        method.AddVehicle((Vehicle)masin);

                        break;

                    case "2":
                        Console.WriteLine("Write vehicle Id     (yoxlamaq asand olsun deye her defe eyni melumaatlari ferqli id ile daxil etmek ucun bele eledim)");

                        Vehicle velo = new Bicycle()
                        {
                            IdCode = Console.ReadLine(),
                            DriveTime = 2,
                            DrivePath = 200,
                            PedalKind = "hybrid",
                            TransmissionKind = "Manual",
                            WheelThickness = 15

                        };
                        method.AddVehicle((Vehicle)velo);

                        break;
                    case "3":
                        Console.WriteLine("Write Vehicle Id");
                        method.RemoveVehicle(Console.ReadLine());

                        break;
                    case "4":
                        method.GetAllCarsId();
                        break;
                    case "5":
                        Console.WriteLine("Write Vehicle ID"); Id = Console.ReadLine();

                        method.GetInfo(Id);

                        break;
                    case "6":
                        iscontinue = false;
                        break;


                }

            }
        }
    }
    }

