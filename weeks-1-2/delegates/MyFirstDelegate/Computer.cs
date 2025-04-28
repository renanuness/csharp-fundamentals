using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDelegate
{
    internal class Computer
    {
        public delegate int CalculateTimeToSend(int packageSize, string ip);


        public void FindRouters()
        {
            var router1 = new RouteOne();
            var router2 = new RouteTwo();
            var router3 = new RouteThree();

            CalculateTimeToSend calculateTimeToSend = new(router1.CalculateRouteTime);
            calculateTimeToSend += router2.CalculateRouteTime;
            calculateTimeToSend += router3.CalculateRouteTime;

            int[] times = new int[3];
            int i = 0;
            foreach (CalculateTimeToSend handler in calculateTimeToSend.GetInvocationList())
            {
                int resultado = handler(200, "192.168.0.1");
                Console.WriteLine($"Retorno: {resultado}");
                times[i++] = resultado;
            }
            times = times.Order().ToArray();

            var a = calculateTimeToSend.GetInvocationList()[1].Target as ISendable;
            a.Send(i);
        }
    }
}
