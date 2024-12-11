using System;

namespace HW_05
{
    public struct Vector2
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        // 加法運算，返回兩個 Vector2 的和
        public Vector2 Add(Vector2 vector2)
        {
            return new Vector2(this.X + vector2.X, this.Y + vector2.Y);
        }

        // 乘法運算，返回兩個 Vector2 的乘積
        public Vector2 Multiply(Vector2 vector2)
        {
            return new Vector2(this.X * vector2.X, this.Y * vector2.Y);
        }

        // 計算當前向量與另一個向量的距離
        public float Distance(Vector2 vector2)
        {
            float offsetX = this.X - vector2.X;
            float offsetY = this.Y - vector2.Y;
            return (float)Math.Sqrt(offsetX * offsetX + offsetY * offsetY);
        }

        // 計算向量長度平方
        public float MagnitudeSquared()
        {
            return (this.X * this.X + this.Y * this.Y);
        }

        // 向量正規化
        public Vector2 Normalize()
        {
            float length = (float)Math.Sqrt(this.X * this.X + this.Y * this.Y);

            if (length == 0)
            {
                return new Vector2(0, 0); // 長度為 0，返回零向量
            }

            return new Vector2(this.X / length, this.Y / length);
        }

        // 返回向量的字串表示
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}