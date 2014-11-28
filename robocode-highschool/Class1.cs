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
           // TurnRadarRight(360); //lata radarem jak szalony
            while (true)
            {
                driving();
                TurnRadarRight(360);
            }
        }


        public void driving() // jezdzenie 
        {
                Ahead(100);
                TurnLeft(30);
                Back(50);
        }

        public void shoot(double distance) //pyk! strzelanie naszym robotem z rozna sila
        {
           // distance okresla odleglosc robota od zeskanowanego przeciwnika
            Fire(3 - distance/250);
         }
         public override void OnScannedRobot(ScannedRobotEvent e)
         {
             TurnGunRight(Heading - GunHeading + e.Bearing);//naprowadzanie
             TurnRadarRight(Heading - GunHeading + e.Bearing); //tu próba ograniczenia latania radarem
             shoot(e.Distance);//strzela jak coś znajdzie
         }

         public override void OnHitByBullet(HitByBulletEvent e)
         {
             TurnGunRight(Heading - GunHeading + e.Bearing); //naprowadzanie
             TurnRadarRight(Heading - GunHeading + e.Bearing); //tu próba ograniczenia latania radarem
             Fire(1);//strzela jak coś znajdzie, ale poniewaz event HitByBullet nie ma pola Distance, strzelam z sila 1 
         }

         public override void OnHitWall(HitWallEvent w)
         {
             TurnLeft(160); // nawrotka
             Ahead(250); // robimy sobie miejsce zeby moc dalej krecic baczki
         }

         public override void OnHitRobot(HitRobotEvent r) // taranujemy przeciwnika, warto zauwazyc, ze moze to oznaczac rowniez obrone przed taranowaniem (ucieczke)
         {
             Back(200); // cofamy
             TurnLeft(90); // i wjezdzamy w przeciwnika jeszcze raz
         }
   }
}
