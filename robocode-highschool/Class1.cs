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


       public override void ourrobotFire(double distance) //pyk! strzelanie naszym robotem z rozna sila
       {
          // distance okresla odleglosc robota od zeskanowanego przeciwnika
           if (distance > 200 || getEnergy() < 20) // gdy mamy malo energii lub przeciwnik jest daleko, strzelamy z mala sila (wtedy pocisk ksztuje malo energii, zadaje malo dmg, ale szybko leci)
               Fire(1); 
           else
               if (distance < 50) // jak przeciwnik jest jakos sensownie blisko i mamy  to strzelamy z wieksza sila 
                    Fire(2);
               else
                   if (distance < 30) // a jak jest bardzo blisko, to nawalamy z calej pary
                       Fire(3);

        }

       public override void targetPractice(ScannedRobotEvent e) // proba wycelowania w naszego przeciwnika
       {
           TurnGunRight(getHeading() - getGunHeading() + e.getBearing()); // zasadniczo przesuwamy armate w te strone, z ktorej widzimy przeciwnika
       }

       // Robot event handler, when the robot sees another robot
       public override void OnScannedRobot(ScannedRobotEvent e)
       {
           targetPractice(e);
           // tu dodac strzelanie
                 
                //można też przypisywać instrukcje do wszystkich rzeczy, które mogą się przydarzyć naszemu robotowi
                //w tym przypadku jest to zauważenie innego robota, po którym warto strzelić ;)
       }
   }
}
