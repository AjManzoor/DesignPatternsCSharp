using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //subject
    public class WeatherData : Subject
    {
        private ArrayList observers;
        private float tempreture;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }

        //add the observer to our array list
        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            int i = observers.IndexOf(o);

            if (i >= 0)
            {
                observers.Remove(i);
            }
        }

        //this sends the messsage to each observer
        public void notifyObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.update(tempreture, humidity, pressure);

            }
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }

        //once we set the measurements we can then notify all the observers
        public void setMeasurements(float tempreture, float humidity, float pressure)
        {
            //[TODO get measurements from API]
            this.tempreture = tempreture;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }

    }
}
