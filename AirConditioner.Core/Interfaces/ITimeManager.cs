using System;

namespace AirConditioner.Core.Interfaces
{
    public interface ITimeManager
    {
        DateTime Current { get; }
    }
}
