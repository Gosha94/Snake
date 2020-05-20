using System;
using Snake.Classes;
using Snake.Enums;
using System.Threading;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            VerticalLine v1 = new VerticalLine( 0, 10, 5, '%' );
            Draw( v1 );

            Point p = new Point( 4, 5, '*' );
            Figure figSnake = new Classes.Snake( p, 4, Direction.Right );
            Draw( figSnake );
            Classes.Snake snake = (Classes.Snake) figSnake;

            HorizontalLine h1 = new HorizontalLine( 0, 5, 6, '&' );
            List<Figure> figures = new List<Figure>();
            figures.Add( figSnake );
            figures.Add( v1 );
            figures.Add( h1 );

            foreach (var f in figures)
            {
                f.Draw();
            }
            Console.ReadKey();
            // Устанавливаем размер окна консоли
                //Console.SetWindowSize( 80, 25 );
            // Чтобы избежать проблем с различными экранами делаем буфер и размер окна одинаковыми
                //Console.SetBufferSize( 80, 25 );
            
            //Drow Borderline
            //HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            //HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            //VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            //VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            
            // Гибкое игровое поле, подстраивается под размер консоли

                //HorizontalLine upLine = new HorizontalLine(0, Console.BufferWidth - 1, 0, '*');
                //HorizontalLine downLine = new HorizontalLine(0, Console.BufferWidth - 1, Console.BufferHeight - 1, '');
                //VerticalLine leftLine = new VerticalLine(0, Console.BufferHeight - 1, 0, '');
                //VerticalLine rigthLine = new VerticalLine(0, Console.BufferHeight - 1, Console.BufferWidth - 1, '');

                //upLine.Draw();
                //downLine.Draw();
                //leftLine.Draw();
                //rightLine.Draw();

            // Создаем точку, но пока ее не рисуем
                //Point point = new Point(10, 10, '*');
            //Создаем змейку, но пока не рисуем ее
                //Classes.Snake snake = new Classes.Snake(point, 6, Direction.Right);
            // Рисуем змейку
                //snake.Draw();
            
            // Создаем объект Еда, передаем в конструктор размеры поля игры и символ еды
                //FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            // Создаем новую точку, и помещаем туда точку с едой, сгенерированную методом CreateFood
                // Point food = foodCreator.CreateFood();
            // Рисуем точку еды
                //food.DrawPoint();

            
            //while ( true )
            //{
            //    // Если направление движение головы змейки попадает на еду, 
            //    // создаем новую рандомную еду на поле, и двигаем змейку
            //    if (snake.Eat(food)) 
            //    {
            //        food = foodCreator.CreateFood();
            //        food.DrawPoint();
            //    }
            //    else snake.Move();

            //    Thread.Sleep( 100 );

            //    if ( Console.KeyAvailable )
            //    {
            //        ConsoleKeyInfo key = Console.ReadKey();
            //        snake.KeyHandle( key.Key );                    
            //    }                
            //}            
        } 
        static void Draw( Figure figure)
        {
            figure.Draw();
        }
               
    }
}
