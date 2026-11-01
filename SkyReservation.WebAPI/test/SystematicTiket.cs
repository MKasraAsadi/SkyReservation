namespace SkyReservation.WebAPI.test;

public class SystematicTiket : AbestractClass
{
    //inject DB Context
    public SystematicTiket(int id, string name, int num, decimal price):base(id, name, num, price)
    {
        //Depend DB Context
    }
    public override decimal CancleTiket(int HoursBifforFlight)
    {
        if (HoursBifforFlight > 24)
            return (price * 0.8m); //80% مبلغ بر میگردد
        return (price * 0.5m); //50 مبلغ بر میگردد
    }
}
