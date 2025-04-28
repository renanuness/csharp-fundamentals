using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDelegate
{
    public interface ISendable
    {
        void Send(int data);
        int CalculateRouteTime(int packageSize, string ip);
    }

    internal class RouteOne : ISendable
    {
        public int CalculateRouteTime(int packageSize, string ip)
        {
            return packageSize * 3;
        }

        public void Send(int data)
        {
            Console.WriteLine("Data sent by Route 1");
        }
    }


    internal class RouteTwo: ISendable
    {
        public int CalculateRouteTime(int packageSize, string ip)
        {
            return packageSize * 4;
        }

        public void Send(int data)
        {
            Console.WriteLine("Data sent by Route 2");
        }
    }

    internal class RouteThree: ISendable
    {
        public int CalculateRouteTime(int packageSize, string ip)
        {
            return packageSize * 4;
        }

        public void Send(int data)
        {
            Console.WriteLine("Data sent by Route 3");
        }
    }
}
