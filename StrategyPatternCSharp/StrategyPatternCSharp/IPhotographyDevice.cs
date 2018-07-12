using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternCSharp
{
    public interface IPhotographyDevice
    {
        string TakeSnap(string  location);
        string RecordVideo(string locatation);
    }
}
