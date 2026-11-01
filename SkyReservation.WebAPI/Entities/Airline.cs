namespace SkyReservation.WebAPI.Entities
{
    /// <summary>
    /// شرکت هواپیمایی
    /// </summary>
    public class Airline
    {
        public int Id { get; set; }
        /// <summary>
        /// نام شرکت هواپیمایی
        /// </summary>
        public string AirlineName { get; set; }
        /// <summary>
        /// کد شکرت هواپیمایی
        /// </summary>
        public string AirlineCode { get; set; }
    }
}
