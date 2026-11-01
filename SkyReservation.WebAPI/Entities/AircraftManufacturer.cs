namespace SkyReservation.WebAPI.Entities
{
    /// <summary>
    /// شرکت سازنده هواپیما ها
    /// </summary>
    public class AircraftManufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        //public ICollection<Aircraft> Aircrafts { get; set; }
        //    = new List<Aircraft>();
    }
}
