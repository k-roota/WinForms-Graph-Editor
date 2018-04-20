using System;
using System.Drawing;

namespace lab7
{
    [Serializable] class Vertex
    {
        private Point pos;
        private static readonly int rad = 12;
        private Color color;

        public Point Pos { get => pos; set => pos = value; }
        public int Rad => rad;
        public Color Color { get => color; set => color = value; }

        public Vertex(Point pos, Color color)
        {
            this.pos = pos;
            this.color = color;
        }

        public int DistanceSquare(Point p)
        {
            return (int)(Math.Pow((p.X - pos.X), 2) + Math.Pow((p.Y - pos.Y), 2));
        }

        public bool Collides(Vertex v)
        {
            return DistanceSquare(v.pos) <= Math.Pow(rad + v.Rad, 2);
        }
    }
}
