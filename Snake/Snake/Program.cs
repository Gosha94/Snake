using System;
using Snake.Classes;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            // Устанавливаем размер окна консоли
            Console.SetWindowSize(80, 25);
            // Чтобы избежать проблем с различными экранами делаем буфер и размер окна одинаковыми
            Console.SetBufferSize(80, 25);
            
            //Drow Borderline
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');

            Console.ReadLine();
        }        
    }
}
