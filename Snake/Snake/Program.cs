using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 0;
            int y1 = 0;
            string sym1 = "&";
            DrawPoint(x1, y1, sym1);

            int x2 = 1;
            int y2 = 1;
            string sym2 = "&";
            DrawPoint(x2, y2, sym2);

            int x3 = 2;
            int y3 = 2;
            string sym3 = "#";
            DrawPoint(x3, y3, sym3);

            Console.ReadLine();
        }

        static void DrawPoint(int x, int y, string sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
