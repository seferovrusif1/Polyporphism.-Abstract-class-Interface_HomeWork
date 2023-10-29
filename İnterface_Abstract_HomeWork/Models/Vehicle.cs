namespace İnterface_Abstract_HomeWork.Models;

internal abstract class Vehicle 
{ 
    public int DriveTime { get; set; }
    public int DrivePath { get; set; }
    public string IdCode { get; set; }

    public void AverageSpeed() 
    {
        Console.WriteLine(DrivePath / DriveTime);
    }
    
   

}
