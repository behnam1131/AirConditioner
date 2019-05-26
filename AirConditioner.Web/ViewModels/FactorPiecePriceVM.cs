namespace AirConditioner.Web.ViewModels
{
    public class FactorPiecePriceVM
    {
        public int Id { get; set; }

        public string comment { get; set; }
        public bool IsChange { get; set; }
        public float Value { get; set; }
        public float priceOne { get; set; }
        public float priceTotal { get; set; }

        public int PiecePriceVMId { get; set; }
        public PiecePriceVM PiecePriceVM { get; set; }

        public int FactorVMId { get; set; }
        public FactorVM FactorVM { get; set; }
    }

}
