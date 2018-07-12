using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //another observer (more info look at current conditionsdisplay)
    class ChangedConditionsDisplay : Observer, DisplayElement
    {
        private float tempreture;
        private float humidity;
        private float oldTempreture;
        private float oldHumidity;
        private float changedTempreture;
        private float changedHumidity;
        private Subject weatherData;

        public ChangedConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            //register this instance
            weatherData.registerObserver(this);
        }

        //this is used by our subject to update the values
        public void update(float tempreture, float humidity, float pressure)
        {
            /*check if this.tempreture has been initialised
             * if it hasn't then it's the first the time that update has been ran 
             * so there should be no change in tempreture
             * so we set it to the value that we've passed
             */

            if (this.tempreture != default(float)){
                oldTempreture = this.tempreture;
            }

            else{
                oldTempreture = tempreture;
            }

            if (this.humidity != default(float)){
                oldHumidity = this.humidity;
            }

            else{
                oldHumidity = humidity;
            }
            
  
            this.tempreture = tempreture;
            this.humidity = humidity;

            changedHumidity = this.humidity - oldHumidity;
            changedTempreture = this.tempreture - oldTempreture;

            display();
        }

        //could use MVC and not display here
        public void display()
        {
            Console.WriteLine(String.Format("The tempreture has changed by {0} degrees and {1} humidity", changedTempreture, changedHumidity));
        }


    }
}
