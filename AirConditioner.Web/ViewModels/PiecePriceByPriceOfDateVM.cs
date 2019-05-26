using System;

namespace AirConditioner.Web.ViewModels
{
    public class PiecePriceByPriceOfDateVM
    {
        public int Id { get; set; }
        public string DateFa { get; set; }
        public string Time { get; set; }

        public DateTime ChangeDateTime { get; set; }
        public double PurchasePrice { get; set; }  // قیمت خرید

        public double PercentageOfSales { get; set; } //درصد فروش

        public int PiecePriceId { get; set; }
        public PiecePriceVM PiecePriceVM { get; set; }
    }



}
