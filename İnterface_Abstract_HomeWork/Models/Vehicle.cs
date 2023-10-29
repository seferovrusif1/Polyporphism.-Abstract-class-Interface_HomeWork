namespace İnterface_Abstract_HomeWork.Models;

internal abstract class Vehicle 
{ 
    public int DriveTime { get; init; }
    public int DrivePath { get; init; }
    public string IdCode { get; set; }

    public float AverageSpeed() 
    {
        return (DrivePath / DriveTime);
    }
    
   

}
