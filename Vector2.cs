using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpTest
{
    class Vector2
    {
        public float X;
        public float Y;

        public Vector2(float x, float y)
        {
            X = x;
            Y = y;     
        }

        public Vector2 Add(Vector2 vector2)
        {
            return new Vector2(X + vector2.X, Y + vector2.Y);
        }
        public Vector2 Multiply(Vector2 vector2)
        {
            return new Vector2(X * vector2.X, Y * vector2.Y);
        }

        public float dis(Vector2 vector2)
        {
            float offsetX = X - vector2.X;
            float offsetY= Y - vector2.Y;
            return (float)System.Math.Sqrt(offsetX * offsetX + offsetY * offsetY);

        }
        public float VectorLong(Vector2 vector2)
        {
            float offsetX = X - vector2.X;
            float offsetY = Y - vector2.Y;
            return (offsetX * offsetX + offsetY * offsetY) / 2;

        }

        public Vector2 Normalize()
        {
            float length = (float)Math.Sqrt(X * X + Y * Y); // 計算自身長度

            if (length == 0) // 防止除以 0
            {
                return new Vector2(0, 0); // 返回零向量
            }

            return new Vector2(X / length, Y / length); // 返回正規化向量
        }

        public string ToStringRepresentation()
        {
            return $"({X}, {Y})";
        }
    }
}
