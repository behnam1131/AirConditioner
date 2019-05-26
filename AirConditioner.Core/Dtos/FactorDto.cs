using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirConditioner.Core.Dtos
{
    public class FactorDto
    {
        public int Id { get; set; }

        [DisplayName("کدفاکتور")]
        public int Code { get; set; }

        [DisplayName("تاریخ")]
        public string DateFa { get; set; }

        [DisplayName("زمان")]
        public string Time { get; set; }
        public DateTime ChangeDateTime { get; set; }
        [DisplayName("توضیحات")]
        [DataType(DataType.MultilineText)]
        public string Comment { get; set; }
        [DisplayName("مدل کولر")]
        public int AirConditionerModelId { get; set; }
        [DisplayName("مدل کولر")]
        public string AirConditionerModelName { get; set; }
        [DisplayName("حجم موتور")]
        public int EngineVolumeId { get; set; }
        [DisplayName("حجم موتور")]
        public string EngineVolumeName { get; set; }

        [DisplayName("کارشناس")]
        public int UserExpertId { get; set; }
        [DisplayName("کارشناس")]
        public string UserExpertName { get; set; }

        [DisplayName("نصاب")]
        public int UserOperatorId { get; set; }
        [DisplayName("نصاب")]
        public string UserOperatorName { get; set; }

        [DisplayName("تکنسین")]
        public int UserTechnicianId { get; set; }
        [DisplayName("تکنسین")]
        public string UserTechnicianName { get; set; }
        [DisplayName("دستیار")]
        public int UserAssistantId { get; set; }
        [DisplayName("دستیار")]
        public string UserAssistantName { get; set; }
        [DisplayName("مشتری")]
        public int CustomerId { get; set; }   // مشتری
        [DisplayName("مشتری")]
        public string CustomerName { get; set; }

        public List<FactorPieceDto> FactorPieceDtos { get; set; }
        public List<FactorWorkDto> FactorWorkDtos { get; set; }

    }
}
