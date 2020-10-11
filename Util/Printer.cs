using static System.Console;

namespace NETCORE.Util
{
    public static class Printer
    {
        public static void LinePaint(int size = 10)
        {
            WriteLine("".PadLeft(size, '='));
        }

        public static void WriteTitle(string title)
        {
            var size =title.Length + 4;
            LinePaint(size);
            WriteLine($"| {title} |");
            LinePaint(size);
        }

        public static void Beep(int hz = 2000, int tiempo=500, int cantidad =1)
        {
            while (cantidad-- > 0)
            {
                System.Console.Beep(hz, tiempo);
            }
        }
    }
}