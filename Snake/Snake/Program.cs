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
                        
            // Устанавливаем размер окна консоли
            Console.SetWindowSize(80, 25);
            // Чтобы избежать проблем с различными экранами делаем буфер и размер окна одинаковыми
            Console.SetBufferSize(80, 25);
            // Отрисовка границ игровой области
            Walls walls = new Walls( 80, 25 );
            walls.Draw();

            // Создаем точку
            Point point = new Point(4, 5, '*');
            // Рисуем змейку из точек, точка point - хвост змейки
            Classes.Snake snake = new Classes.Snake(point, 4, Direction.Right);            
            snake.Draw();
            
            // Создаем объект Еда, передаем в конструктор размеры поля игры и символ еды
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            // Создаем новую точку, и помещаем туда точку с едой, сгенерированную методом CreateFood
            Point food = foodCreator.CreateFood();
            // Рисуем точку еды
            food.DrawPoint();


            while (true)
            {
                // Если змейка попадает в границу поля, либо в свой хвост
                if ( walls.IsHit(snake) || snake.IsHitTail() ) 
                {
                    // Завершаем бескончный цикл
                    break;
                }
                // Если направление движение головы змейки попадает на еду, 
                // создаем новую рандомную еду на поле, и двигаем змейку
                if ( snake.Eat( food ) )
                {
                    food = foodCreator.CreateFood();
                    food.DrawPoint();
                }
                else snake.Move();

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.KeyHandle(key.Key);
                }
            } // END_while (true)
            GameOver();
        }
        static void GameOver()
        {
            Console.SetCursorPosition( 10, 10 );
            Console.WriteLine("Ха, проиграл, лошара?");
            Console.ReadKey();
        }
    }
}
