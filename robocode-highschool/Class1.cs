using System;
using Robocode;
using Robocode.Control;
using Robocode.Control.Events;

namespace robocode_highschool
{
    public class HighRobot : Robot
    {
        // Your Run method must be public, is void, and must override the Run() method from the super class
        public override void Run()
        {
            // Perform your initialization for your robot here
            //czyli tutaj ma być to, co robi po tym, jak pojawi się na planszy

            while (true)
            {
                // Perform robot logic here calling robot commands etc.
                //our code comes here... ;)
                //tutaj wchodzi zapętlone wszystko, co robi potem, chodzenie, ruszanie lufą itp...
            }
        }
             // Robot event handler, when the robot sees another robot
            public override void OnScannedRobot(ScannedRobotEvent e)
            {
                 // We fire the gun with bullet power = 1
                 
                //można też przypisywać instrukcje do wszystkich rzeczy, które mogą się przydarzyć naszemu robotowi
                //w tym przypadku jest to zauważenie innego robota, po którym warto strzelić ;)
            }
     }
}
