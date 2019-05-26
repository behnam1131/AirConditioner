using System;
using System.Collections.Generic;

namespace AirConditioner.Core.Models
{
    public class Factor
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string DateFa { get; set; }
        public string Time { get; set; }
        public DateTime ChangeDateTime { get; set; }
        public string Comment { get; set; }


        public int AirConditionerModelId { get; set; }
        public AirConditionerModel AirConditionerModel { get; set; }

        public int EngineVolumeId { get; set; }
        public EngineVolume EngineVolume { get; set; }


        public int UserExpertId { get; set; }        
        public UserExpert UserExpert { get; set; }


        public int UserOperatorId { get; set; }
        public UserOperator UserOperator { get; set; }

        public int UserTechnicianId { get; set; }
        public UserTechnician UserTechnician { get; set; }

        public int UserAssistantId { get; set; }
        public UserAssistant UserAssistant { get; set; }
               

        public int CustomerId { get; set; }   // مشتری
        public Customer Customer { get; set; }

        public virtual ICollection<FactorPiece> FactorPiecePrices { get; set; }
        public virtual ICollection<FactorWork> FactorWorks { get; set; }



    }



}
