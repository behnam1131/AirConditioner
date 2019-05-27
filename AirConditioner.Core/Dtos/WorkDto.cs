using System.ComponentModel;

namespace AirConditioner.Core.Dtos
{
    public class WorkDto
    {
        public int Id { get; set; }
        [DisplayName("نام")]
        public string Name { get; set; }
    }
}
