namespace SkyReservation.WebAPI.test;

public class ChartriTiket : AbestractClass
{
    public ChartriTiket(int id, string name, int num, decimal price) : base(id , name, num, price)
    {
        
    }
    public override decimal CancleTiket(int HoursBifforFlight)
    {
        Console.WriteLine("هشدار : پرواز های چارتری غیر قابل استرداد وجه و لغو می باشد");
        return 0;
    }
}
