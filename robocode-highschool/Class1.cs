using System;
using Robocode;
using Robocode.Control;
using Robocode.Control.Events;
using Robocode.Util;

//robocode.util.Utils;

namespace robocode_highschool
{
    public class HighRobot : Robot
    {
        // Your Run method must be public, is void, and must override the Run() method from the super class
        public override void Run()
        {
            TurnRadarRight(360); //lata radarem jak szalony
            while (true)
            {
                
            }
        }


       public void ourrobotFire(double distance) //pyk! strzelanie naszym robotem z rozna sila
       {
          // distance okresla odleglosc robota od zeskanowanego przeciwnika
           if (distance > 200 ||  Energy < 20) // gdy mamy malo energii lub przeciwnik jest daleko, strzelamy z mala sila (wtedy pocisk ksztuje malo energii, zadaje malo dmg, ale szybko leci)
               Fire(1); 
           else
               if (distance < 50) // jak przeciwnik jest jakos sensownie blisko i mamy  to strzelamy z wieksza sila 
                    Fire(2);
               else
                   if (distance < 30) // a jak jest bardzo blisko, to nawalamy z calej pary
                       Fire(3);

        }


       // Robot event handler, when the robot sees another robot
       public override void OnScannedRobot(ScannedRobotEvent e)
       {
           TurnGunRight(Heading - GunHeading + e.Bearing);//naprowadzanie
           TurnRadarRight(Heading - GunHeading + e.Bearing); //tu próba ograniczenia latania radarem
           ourrobotFire(e.Distance);//strzela jak coś znajdzie
       }
   }
}
