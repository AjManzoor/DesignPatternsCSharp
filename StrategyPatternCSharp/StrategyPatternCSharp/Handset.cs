using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternCSharp
{
    public abstract class Handset
    {
        //create an instance of the interface
        public IPhotographyDevice photographyDevice;

        public abstract string Display();

        //functions thata all children will gave
        public string MakeACall(string desinationNumber)
        {
            return String.Format("Calling{0}", desinationNumber);
        }

        public string SendSms(string desinationNumber)
        {
            return String.Format("Sending sms number{0}", desinationNumber);
        }

        public string TakeSnap(string location)
        {
            if (photographyDevice != null)
            {
                return photographyDevice.TakeSnap(location);
            }
            else
            {
                return @"Sorry! this phone doesn't support photography";
            }
        }

        public string RecordVideo(string location)
        {
            if (photographyDevice != null)
            {
                return photographyDevice.RecordVideo(location);
            }
            else
            {
                return @"Sorry! this phone doesn't support videography";
            }
        }

        public void SetPhotographyDevice(IPhotographyDevice pd)
        {
             photographyDevice = pd;
        }




    }
}
