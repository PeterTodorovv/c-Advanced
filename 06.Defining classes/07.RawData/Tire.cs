﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    class Tire
    {
        public int Age { get; set; }
        public double Pressure { get; set; }

        public Tire(int age, double pressure)
        {
            this.Age = age;
            this.Pressure = pressure;
        }
    }
}
