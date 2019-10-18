using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0830
{
    class AirConditioner
    {
        int temperature;

        void SetTemperature(int temperature)
        {
            if (temperature < 15 || temperature > 25)
            {
                Console.WriteLine("적절한 실내온도 설정이 아닙니다.");
            }

            this.temperature = temperature;
        }

        void TurnOnAirConditioner()
        {
            if (this.temperature >= 15 && this.temperature <= 25)
                Console.WriteLine("에어컨을 켭니다. : {0}", temperature);
            else
                Console.WriteLine("적절한 실내온도를 설정하여 주십시오.");
        }
    }

    class AccessModifier
    {
        static void Main(string[] args)
        {
            
        }
    }
}
