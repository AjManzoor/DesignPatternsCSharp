using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternCSharp
{
    class FrontCamera : IPhotographyDevice
    {
        public int megaPixels { get; set; }
        public FrontCamera(int supportMegaPixels)
        {
            megaPixels = supportMegaPixels;
        }

        public string TakeSnap(string Location)
        {
            return String.Format("Taking Photograph on {0} MP front camera", megaPixels.ToString());
        }

        public string RecordVideo(string location)
        {
            return String.Format("Recording Videov on {0} MP front camera", megaPixels.ToString());
        }
    }
}

