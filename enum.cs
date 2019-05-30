using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var traf = new Traffic();
            traf.TriggerLights();
        }
    }

    public class Traffic
    {
        enum LightColors
        {
            Red,
            Green,
            Orange,
            Purple
        }

        public void TriggerLights()
        {
            Console.WriteLine(Enum.GetName(typeof(LightColors), 3));
        }
    }
}
