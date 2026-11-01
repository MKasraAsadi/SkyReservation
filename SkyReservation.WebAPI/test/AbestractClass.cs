namespace SkyReservation.WebAPI.test;

public abstract class AbestractClass
{
    //Feilds
    public int id { get; set; }
    public string name { get; set; }
    public int numberd { get; set; }
    public decimal price { get; set; }

    protected AbestractClass(int id , string name , int num,decimal price)
    {
        this.id = id;
        this.name = name;
        this.numberd = num;
        this.price = price;
    }
    public void SendMessage()
    {
        Console.WriteLine($"بلیط با شماره {numberd} برای مسافر {name} صادر گردید.");
    }
    public  decimal CalcPrice()
    {
        return this.price * 0.10m;
    }
    public abstract decimal CancleTiket(int HoursBifforFlight);
}
