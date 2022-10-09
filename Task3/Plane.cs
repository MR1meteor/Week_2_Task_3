namespace Task3
{
    public class Plane : ICanFly
    {
        public int CurrentHeight { get; private set; }
        public double CurrentSpeed { get; private set; }

        /// <summary>
        /// Угол атаки, -180 - 180
        /// </summary>
        public int AttackAngle { get; private set; }

        /// <summary>
        /// Положение РУД, %
        /// </summary>
        public int ThrustLeverState { get; private set; }
        public int MaxSpeed { get; private set; }

        public Plane()
        {
            CurrentHeight = 0;
            CurrentSpeed = 0;
            AttackAngle = 0;
            ThrustLeverState = 0;
            MaxSpeed = 1000;
        }

        public Plane(int currentHeight, int currentSpeed, int attackAngle, int thrustLeverState, int maxSpeed)
        {
            CurrentHeight = currentHeight;
            CurrentSpeed = currentSpeed;
            AttackAngle = attackAngle;
            ThrustLeverState = thrustLeverState;
            MaxSpeed = maxSpeed;
        }

        public Plane(Plane plane)
        {
            CurrentHeight = plane.CurrentHeight;
            CurrentSpeed = plane.CurrentSpeed;
            AttackAngle = plane.AttackAngle;
            ThrustLeverState = plane.ThrustLeverState;
            MaxSpeed = plane.MaxSpeed;
        }

        public void GoAbove(int height)
        {
            int targetHeight = CurrentHeight + height;
            ThrustLeverState = CurrentSpeed > 0 ? ThrustLeverState : 100;
            AttackAngle = 40;

            while (CurrentHeight < targetHeight)
            {
                CurrentHeight++;
                CurrentSpeed += 0.1;
            }

            AttackAngle = 0;
            ThrustLeverState = (int)(CurrentSpeed / MaxSpeed * 100);

            Console.WriteLine($"Самолет поднялся на {height} метров и теперь имеет высоту {CurrentHeight}, летит со скоростью {Math.Floor(CurrentSpeed)}");
        }

        public void GoBelow(int height)
        {
            int targetHeight = CurrentHeight - height < 0 ? 0 : CurrentHeight - height;
            ThrustLeverState = 0;
            AttackAngle = -40;

            while (CurrentHeight > targetHeight)
            {
                CurrentHeight--;
                CurrentSpeed += 0.2;
            }

            AttackAngle = 0;
            ThrustLeverState = (int)(CurrentSpeed / MaxSpeed * 100);

            Console.WriteLine($"Самолет опустился на {height} метров и теперь имеет высоту {CurrentHeight}, летит со скоростью {Math.Floor(CurrentSpeed)}");
        }
    }
}
