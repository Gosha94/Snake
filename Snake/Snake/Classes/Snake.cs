using Snake.Enums;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Snake.Classes
{
    class Snake : Figure
    {
        // Задаем переменную для направления движения через поле
        Direction direction;
        // Абстракция - способ учитывать только важные для конкретной ситуации свойства класса
        // 1 - Змейка - некоторая фигура на поле (наследуем от класса Figure)
        // 2 - Змейка состоит из точек, у Змейки есть некая стартовая позиция, 
        // она двигается в опред направлении, все это будет в конструкторе

        // В конструкторе указываем координаты точки хвоста, длину змейки, направление поворота головы змейки
        public Snake(Point snakeTail, int snakeLength, Direction direction)
        {
            this.direction = direction;
            pointsList = new List<Point>();
                        
            for (int i = 0; i < snakeLength; i++)
            {
                Point p = new Point( snakeTail );
                p.Move( i, direction );
                pointsList.Add( p );
            }

            
        }

        internal void Move()
        {
            Point tail = pointsList.First();
            pointsList.Remove( tail );
            Point head = GetNextPoint();
            pointsList.Add( head );
            // Удаляем крайнюю с конца точку хвоста змейки
            tail.Clear();
            head.DrawPoint();
        }

        private Point GetNextPoint()
        {
            Point head = pointsList.Last();
            Point nextPoint = new Point( head );
            nextPoint.Move( 1, this.direction );
            return nextPoint;
        }

        public void KeyHandle( ConsoleKey key )
        {
            if ( key == ConsoleKey.LeftArrow )
                direction = Direction.Left;
            else if ( key == ConsoleKey.RightArrow )
                direction = Direction.Right;
            else if ( key == ConsoleKey.DownArrow )
                direction = Direction.Down;
            else if ( key == ConsoleKey.UpArrow )
                direction = Direction.Up;
        }

        internal bool Eat( Point food )
        {
            Point head = GetNextPoint();
            // Если координата головы змейки совпадает с координатой еды
            if (head.IsHit(food))
            {
                // Заменяем еду на голову змейки и увеличиваем змейку
                food.sym = head.sym;
                pointsList.Add(food);
                return true;
            }
            else return false;
        }
    }
}
