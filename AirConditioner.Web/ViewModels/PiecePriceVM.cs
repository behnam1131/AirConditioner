
using System.Collections.Generic;
using System.Text;

namespace AirConditioner.Web.ViewModels
{
    public class PiecePriceVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string DateFa { get; set; }
        public string PieceTitle { get; set; }

        public int PieceId { get; set; }
        public PieceVM PieceVM { get; set; }

        public double PercentageOfSales { get; set; }

        public double Price { get; set; }     

    }

}
