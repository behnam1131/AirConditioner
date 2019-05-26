using AirConditioner.Core.Interfaces;
using System;

namespace AirConditioner.Application.Service
{
    public class TimeManager : ITimeManager
    {
        public DateTime Current => DateTime.Now;
    }

    public class UtcTimeManager : ITimeManager
    {
        public DateTime Current => DateTime.UtcNow;
    }
}
