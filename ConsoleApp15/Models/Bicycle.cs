using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15.Models
{
    class Bicycle:Vehicle
    {
        public Bicycle()
        {

        }
        public Bicycle(string color, string model)
        {
            this.color = color;
            this.model = model;
            Console.WriteLine(color + " " + model);
        }
        public Bicycle(int cycle, int passengercount)
        {
            this.cycle = cycle;
            this.passengerCount = passengercount;
            Console.WriteLine(cycle + " " + passengercount);
        }
        public Bicycle(int driveway, int drivetime, int getspeed)
        {
            this.driveWay = driveway;
            this.driveTime = drivetime;
            this.getSpeed = getspeed;
            Console.WriteLine(driveway + " " + drivetime + " " + getspeed);
        }
        public Bicycle(string color, string model, int cycle, int passengercount, int driveway, int drivetime, int getspeed)
        {
            Console.WriteLine(color + " " + model + " " + cycle + " " + passengercount + " " + driveway + " " + drivetime + " " + getspeed);
        }
    }
}
