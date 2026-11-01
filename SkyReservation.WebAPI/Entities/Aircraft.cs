namespace SkyReservation.WebAPI.Entities
{
    /// <summary>
    /// هواپیما
    /// </summary>
    public class Aircraft
    {
        public int Id { get; set; }
        //شرکت سازنده
        public int AircraftManufacturerID { get; set; }
        public string Model { get; set; }
        public bool Status { get; set; }
        //ظرفیت
        public int Capacity { get; set; }
        //سال ساخت
        public int YearOfConstruction { get; set; }
        public string RegistrationNumber { get; set; }
    }
}
