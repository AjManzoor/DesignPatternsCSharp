using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //register the subject (What everyone is listening to)
            WeatherData weatherData = new WeatherData();

            //register the observer passing the subject (who is actually listening)
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            ChangedConditionsDisplay changedConditionsDisplay = new ChangedConditionsDisplay(weatherData);

            //update the subject (this will send the data to all the subjects) 
            weatherData.setMeasurements(80, 65, 30);
            weatherData.setMeasurements(20, 20, 20);

            Console.ReadKey();
        }
    }
}
