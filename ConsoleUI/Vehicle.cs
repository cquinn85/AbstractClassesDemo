using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    //(DONE) Create an abstract class called Vehicle
    public abstract class Vehicle
    {
        /* (DONE)The vehicle class shall have three string properties:
            Year, Make, and Model*/
        public int Year { get; set; } = 1;
        public string Make { get; set; } = default;
        public string Model { get; set; } = default;

        /* Set the defaults to something generic in the Vehicle class ^^(above)
              * Vehicle shall have an abstract method called 
                DriveAbstract with no implementation
              * Vehicle shall have a virtual method called 
                DriveVirtual with a base implementation.*/

        public abstract void DriveAbstract(); // stubbed out method = no implementation

        public virtual void DriveVirtual()
        {
            //Vehicle shall have a virtual method called DriveVirtual
            //with a base implementation. ^^ (implementation was the 
            //curly braces instead of semicolon.)
            Console.WriteLine($"This {GetType().Name} is virutually in drive.");
        }
    }
}
