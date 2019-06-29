using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AirConditioner.Helper
{
    public class EnumMember
    {
    }


    public enum Actor
    {
        [Display(Name = "نصاب")]
        UserOperator = 1,
        [Display(Name = "تکنسین")]
        UserTechnician = 2,
        [Display(Name = "کارشناس")]
        UserExpert = 3,
        [Display(Name = "دستیار")]
        UserAssistant = 4
    }

}
