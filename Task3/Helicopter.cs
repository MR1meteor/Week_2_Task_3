namespace Task3
{
    public class Helicopter : ICanFly
    {
        public int CurrentHeight { get; private set; }

        public int MaxHeight { get; private set; }

        /// <summary>
        /// Скорость вращения несущего винта, %
        /// </summary>
        public int RotorThrust { get; private set; }

        /// <summary>
        /// Угол атаки, 0 - 360
        /// </summary>
        public int AttackAngle { get; private set; }

        public Helicopter()
        {
            CurrentHeight = 0;
            RotorThrust = 0;
            AttackAngle = 0;
            MaxHeight = 2000;
        }

        public Helicopter(int height, int rotorThrust, int attackAngle, int maxHeight)
        {
            CurrentHeight = height;
            RotorThrust = rotorThrust;
            AttackAngle = attackAngle;
            MaxHeight = maxHeight;
        }

        public Helicopter(Helicopter helicopter)
        {
            CurrentHeight = helicopter.CurrentHeight;
            RotorThrust = helicopter.RotorThrust;
            AttackAngle = helicopter.AttackAngle;
            MaxHeight = helicopter.MaxHeight;
        }

        public void GoAbove(int height)
        {
            int targetHeight = MaxHeight <= CurrentHeight + height ? CurrentHeight + height : MaxHeight;
            AttackAngle = 0;
            RotorThrust = 100;

            while (CurrentHeight < targetHeight)
                CurrentHeight++;

            RotorThrust = CurrentHeight / MaxHeight * 100;

            Console.WriteLine($"Вертолет поднялся на {height} метров и имеет высоту {CurrentHeight} метров");
        }

        public void GoBelow(int height)
        {
            int targetHeight = CurrentHeight - height < 0 ? 0 : CurrentHeight - height;
            AttackAngle = 0;
            RotorThrust = 0;

            while (CurrentHeight > targetHeight)
                CurrentHeight--;

            RotorThrust = CurrentHeight / MaxHeight * 100;

            Console.WriteLine($"Вертолет опустился на {height} метров и имеет высоту {CurrentHeight} метров");
        }
    }
}
