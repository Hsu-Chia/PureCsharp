using System;

namespace CsharpTest
{
    class Rectangle
    {
        public void Hw_04_01()
        {
            Console.WriteLine("請輸入希望的階層");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            for (int i = 0; i <=num; i++)
            {
                string output = "";
                for (int j = 0; j < num - i; j++)
                {

                    output += "";
                
                }
                for (int j = 1; j <= i; j++)
                {
                    output += "*";

                }

                Console.WriteLine(output);
           }
        }
        public void Hw_04_02()
        {
            Vector2 player1 = new Vector2(1, 2);
            Vector2 player2 = new Vector2(3, 5);
            Vector2 sum = player1.Add(player2);
            Vector2 product = player1.Multiply(player2);
            Console.WriteLine($"Sum: {sum.ToStringRepresentation()}");
            Console.WriteLine($"Product: {product.ToStringRepresentation()}");

        }

        public void Hw_04_03()
        {
            Vector2 player1 = new Vector2(1, 2);
            Vector2 player2 = new Vector2(3, 5);
            float dis= player1.dis(player2);
            Console.WriteLine(dis);
        }

        public void Hw_04_04()
        {
            // 建立向量 (6, 8)
            Vector2 player1 = new Vector2(6, 8);

            // 計算正規化向量
            Vector2 normalized = player1.Normalize();

            // 輸出結果
            Console.WriteLine($"Original Vector: ({player1.X}, {player1.Y})");
            Console.WriteLine($"Normalized Vector: ({normalized.X}, {normalized.Y})");
        }

        public void Hw_04_05()
        {
            player player1 = new player();
            player1.SetHp(100);
            player1.position = new Vector2(0, 0);
            player player2= new player();
            player2.SetHp(0);
            player2.position = new Vector2(4, 3);
            player1.playerinform();
            player2.playerinform();
            float distance = player1.position.dis(player2.position);
            Console.WriteLine($"兩個玩家之間的距離：{distance}");

        }

        static void Main(string[] args)
        {

            Rectangle r = new Rectangle();

            while (true)
            {
                Console.WriteLine("請輸入作業名稱");
                String HWN = Console.ReadLine();
                if (HWN == "Hw_04_01")
                {
                    r.Hw_04_01();
                }
                else if (HWN == "Hw_04_02")
                {
                    r.Hw_04_02();
                }
                else if (HWN == "Hw_04_03")
                {
                    r.Hw_04_03();
                }
                else if (HWN == "Hw_04_04")
                {
                    r.Hw_04_04();
                }
                else if (HWN == "Hw_04_05")
                {
                    r.Hw_04_05();
                }
                else if (HWN == "Q")
                {
                    Console.WriteLine("程式已結束感謝使用");
                    break;
                }
                else
                {
                    Console.WriteLine("未找到對應作業名稱");
                }
            }
        }
    }
}
