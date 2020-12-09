using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormTempConverter
{
    public class Conversion
    {
        //pure methods
        public string FahToCel(string Fah)
        {
            Single Fahrenheit = Convert.ToSingle(Fah);
            Single Celsius = (float)((5.0 / 9.0) * (Fahrenheit - 32.0));
            return Celsius.ToString();

        }
        public string CelToFah(string Cel)
        {
            Single Celsius = Convert.ToSingle(Cel);
            Single Fahrenheit = (float)(Celsius * (9.0 / 5.0) + 32);
            return Fahrenheit.ToString();

        }


    }
}
