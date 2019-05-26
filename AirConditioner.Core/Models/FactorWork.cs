namespace AirConditioner.Core.Models
{
    public class FactorWork
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public double Price { get; set; }


        public int FactorId { get; set; }
        public Factor Factor { get; set; }

        public int WorkId { get; set; }
        public Work Work { get; set; }
    }
}
