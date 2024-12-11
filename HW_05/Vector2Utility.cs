using System;
using HW_05;

namespace CsharpTest.HW_05
{
    public static class Vector2Utility
    {
        // Add方法：計算兩個Vector2的和
        public static Vector2 Add(Vector2 vector1, Vector2 vector2)
        {
            return new Vector2(vector1.X + vector2.X, vector1.Y + vector2.Y);
        }

        // Multiply方法：計算兩個Vector2的積
        public static Vector2 Multiply(Vector2 vector1, Vector2 vector2)
        {
            return new Vector2(vector1.X * vector2.X, vector1.Y * vector2.Y);
        }

        // Dot方法：計算兩個Vector2的內積
        public static float Dot(Vector2 vector1, Vector2 vector2)
        {
            return vector1.X * vector2.X + vector1.Y * vector2.Y;
        }

        // Distance方法：計算兩個Vector2的距離
        public static float Distance(Vector2 vector1, Vector2 vector2)
        {
            float deltaX = vector2.X - vector1.X;
            float deltaY = vector2.Y - vector1.Y;
            return (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        // Magnitude方法：計算一個Vector2的長度
        public static float Magnitude(Vector2 vector)
        {
            return (float)Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
        }

        // Normalize方法：計算一個Vector2的Normalize值
        public static Vector2 Normalize(Vector2 vector)
        {
            float magnitude = Magnitude(vector);
            if (magnitude == 0)
            {
                return new Vector2(0, 0); // 長度為0時，返回(0, 0)
            }
            return new Vector2(vector.X / magnitude, vector.Y / magnitude);
        }
    }
}