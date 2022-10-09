namespace Task3
{
    public interface ICanFly
    {
        /// <summary>
        /// Текущая высота в метрах
        /// </summary>
        public int CurrentHeight { get; }

        /// <summary>
        /// Повышает высоту на заданное значение
        /// </summary>
        /// <param name="height"></param>
        public void GoAbove(int height);

        /// <summary>
        /// Понижает высоту на заданное значение
        /// </summary>
        /// <param name="height"></param>
        public void GoBelow(int height);
    }
}
