using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //implment observer interface
    //implement displayelement interface as we want to dispaly the data at this point (Don't need to)
    class CurrentConditionsDisplay: Observer, DisplayElement 
    {
        private float tempreture;
        private float humidity;
        private Subject weatherData;

        //register this observer in the constructor
        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            //register this instance
            weatherData.registerObserver(this);
        }

        //this is used by our subject to update the values
        public void update(float tempreture, float humidity, float pressure)
        {
            this.tempreture = tempreture;
            this.humidity = humidity;
            display();
        }

        //could use MVC and not display here
        public void display()
        {
            Console.WriteLine(String.Format("Current conditions: {0} degrees and {1} humidity", tempreture,humidity));
        }
    }
}
