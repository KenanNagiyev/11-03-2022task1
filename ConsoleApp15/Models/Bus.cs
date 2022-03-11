using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15.Models
{
    class Bus:Vehicle 
    {
        public double motor;
        public Bus()
        {

        }
        public Bus(double motor)
        {
            this.motor = motor;
            Console.WriteLine(motor);
        }
        
        public Bus(string color, string model)
        {
            this.color = color;
            this.model = model;
            Console.WriteLine(color + " " + model);
        }
        public Bus(int cycle , int passengercount)
        {
            this.cycle = cycle;
            this.passengerCount = passengercount;
            Console.WriteLine(cycle + " " + passengercount);
        }
        public Bus(int driveway, int drivetime, int getspeed)
        {
            this.driveWay = driveway;
            this.driveTime = drivetime;
            this.getSpeed = getspeed;
            Console.WriteLine(driveway + " " + drivetime + " " + getspeed);
        }
        public Bus(string color, string model, int cycle, int passengercount, int driveway, int drivetime, int getspeed)
        {
            Console.WriteLine(motor + " " +color + " " + model + " " + cycle + " " + passengercount + " " + driveway + " " + drivetime + " " + getspeed);
        }
    }
    
}
