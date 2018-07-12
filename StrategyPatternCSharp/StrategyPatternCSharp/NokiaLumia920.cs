using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternCSharp
{
   public class NokiaLumia920 : Handset
    {
        private readonly int rearCameraMPs = 12;
        private readonly int mainCameraMPs = 12;
        private readonly int frontCameraMPs = 5;

        public NokiaLumia920()
        {
            //delegate the resposability to the photragpyDevice 
            photographyDevice = new MainCamera(mainCameraMPs);
        }

        
        public void LoadFrontCamera()
        {
            SetPhotographyDevice(new FrontCamera(frontCameraMPs));
        }

        public void LoadRearCamera()
        {
            SetPhotographyDevice(new RearCamera(rearCameraMPs));
        }
        

        public override string Display()
        {
            return "Nokia Lumia 920... A full-featured phone from Nokia";
        }

    }
}
