using System.Collections.Generic;

namespace AirConditioner.Web.ViewModels
{
    public class PieceVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PiecePriceVM> PiecePriceVMs { get; set; }

    }



}
