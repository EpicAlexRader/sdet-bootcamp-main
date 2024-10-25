namespace SdetBootcampDay2.TestObjects.Examples.DIP_After
{
    public class Computer
    {
        private readonly Keyboard _keyboard;
        private readonly IMonitor _monitor;

        public Computer(Keyboard keyboard, IMonitor monitor)
        {
            this._keyboard = keyboard;
            this._monitor = monitor;

            monitor.Resolution();
        }
    }

    public class Keyboard
    {
    }

    public interface IMonitor
    {
        int Resolution();
    }

    public class HDMonitor : IMonitor
    {
        public int Resolution(){return 1920;}
    }

    public class FourKMonitor : IMonitor
    {
        public int Resolution(){return 4000;}
    }
}
