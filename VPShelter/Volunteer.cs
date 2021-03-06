﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Volunteer : Employee
    {
        private string volHours;

        // additional property
        public string VolHours
        {
            get { return this.volHours; }
            set { this.volHours = value; }
        }


        //Constructor
        public Volunteer()
        {
            //default
        }

        //method to feed pets
        public void FeedPet()
        {
            Console.WriteLine();
            Console.WriteLine("You have fed all of the pets.");
            Console.WriteLine();
        }

        //method to water pets
        public void WaterPet()
        {
            Console.WriteLine();
            Console.WriteLine("You gave all of the pets water.");
            Console.WriteLine();
        }


        //override
        public override void ClockIn()
        {
            Console.WriteLine("You have clocked in as a volunteer.");
        }
    }
}
