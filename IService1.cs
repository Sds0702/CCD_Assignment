using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceTempConvertion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        double CelsiustoFahrenheit(double CTemp);
        [OperationContract]
        double CelsiustoKelvin(double CTemp);
        [OperationContract]
        double FahrenheittoCelsius(double FTemp);
        [OperationContract]
        double FahrenheittoKelvin(double FTemp);
        [OperationContract]
        double KelvintoCelsius(double KTemp);
        [OperationContract]
        double KelvintoFahrenheit(double KTemp);
    }
}
