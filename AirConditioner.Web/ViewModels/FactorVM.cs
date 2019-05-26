using System;
using System.Collections.Generic;

namespace AirConditioner.Web.ViewModels
{
    public class FactorVM
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string DateFa { get; set; }
        public string Time { get; set; }
        public DateTime ChangeDateTime { get; set; }
        public string comment { get; set; }


        public int AirConditionerNameId { get; set; }
        public AirConditionerNameVM AirConditionerNameVM { get; set; }

        public int EngineVolumeId { get; set; }
        public EngineVolumeVM EngineVolumeVM { get; set; }


        public int UserExpertVMId { get; set; }        
        public UserExpertVM UserExpertVM { get; set; }


        public int UserOperatorVMId { get; set; }
        public UserOperatorVM UserOperatorVM { get; set; }

        public int UserTechnicianVMId { get; set; }
        public UserTechnicianVM UserTechnicianVM { get; set; }

        public int UserAssistantVMId { get; set; }
        public UserAssistantVM UserAssistantVM { get; set; }
               

        public int CustomerId { get; set; }   // مشتری
        public CustomerVM CustomerVM { get; set; }

        public List<FactorPiecePriceVM> FactorPiecePriceVM { get; set; }


    }



}
