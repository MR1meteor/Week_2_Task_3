namespace Task3
{
    public class Pigeon : ICanFly
    {
        public int CurrentHeight { get; private set; }

        /// <summary>
        /// Частота взмахов крыльев
        /// </summary>
        public double WingBeatFrequency { get; private set; }

        private const int MaxWingBeatFrequensy = 5;
        private const int MaxHeight = 1500;

        public Pigeon()
        {
            CurrentHeight = 0;
            WingBeatFrequency = 0;
        }

        public Pigeon(int height, int wingBeatFrequency)
        {
            CurrentHeight = height;
            WingBeatFrequency = wingBeatFrequency;
        }

        public Pigeon(Pigeon pigeon)
        {
            CurrentHeight = pigeon.CurrentHeight;
            WingBeatFrequency = pigeon.WingBeatFrequency;
        }

        public void GoAbove(int height)
        {
            int targetHeight = CurrentHeight + height > MaxHeight ? MaxHeight : CurrentHeight + height;
            WingBeatFrequency = MaxWingBeatFrequensy;

            while(CurrentHeight < targetHeight)
                CurrentHeight++;

            WingBeatFrequency = MaxWingBeatFrequensy * (CurrentHeight / MaxHeight);

            Console.WriteLine($"Голубь взлетел на {height} метров");
        }

        public void GoBelow(int height)
        {
            int targetHeight = CurrentHeight - height < 0 ? 0 : CurrentHeight - height;
            WingBeatFrequency = 0;

            while (CurrentHeight < targetHeight)
                CurrentHeight--;

            WingBeatFrequency = MaxWingBeatFrequensy * (CurrentHeight / MaxHeight);

            Console.WriteLine($"Голубь опустился на {height} метров");
        }
    }
}
