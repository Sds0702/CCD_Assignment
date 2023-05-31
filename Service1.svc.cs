using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceTempConvertion
{
        public class Service1 : IService1
    {
        public double CelsiustoFahrenheit(double CTemp)
        {
            double f = (CTemp * 1.8) + 32;
            return f;
        }
        public double CelsiustoKelvin(double CTemp)
        {
            double k = CTemp + 273.15;
            return k;
        }
        public double FahrenheittoCelsius(double FTemp)
        {
            double c = (FTemp - 32) * 0.55;
            return c;
        }
        public double FahrenheittoKelvin(double FTemp)
        {
            double k = (FTemp - 32) * 0.55 + 273.15;
            return k;
        }
        public double KelvintoCelsius(double KTemp)
        {
            double c = KTemp - 273.15;
            return c;
        }
        public double KelvintoFahrenheit(double KTemp)
        {
            double f = (KTemp - 273.15) * 0.55 + 273.15;
            return f;
        }
    }
}
