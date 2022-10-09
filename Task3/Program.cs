namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICanFly helicopter = new Helicopter(100, 20, 0, 1000);
            ICanFly plane = new Plane(1000, 460, 0, 60, 1300);
            ICanFly pigeon = new Pigeon();

            helicopter.GoAbove(300);
            plane.GoAbove(3000);
            pigeon.GoAbove(100);

            Console.WriteLine();

            helicopter.GoBelow(200);
            plane.GoBelow(2000);
            pigeon.GoBelow(40);
        }
    }
}