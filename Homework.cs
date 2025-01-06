using System;
using System.Collections.Generic;
using System.Text;
using HW_04;
using Counter1 = Hw_05_Counter_1.Counter;
using Counter2 = Hw_05_Counter_2.Counter;
using Counter3 = Hw_05_Counter_3.Counter;
using CsharpTest.HW_05;
using Vector2_04 = HW_04.Vector2;
using Vector2_05 = HW_05.Vector2;
using CsharpTest.HW_06;


namespace CsharpTest
{
    class Homework
    {
        public void Run()
        {

            

            while (true)
            {
                Console.WriteLine("請輸入作業名稱");
                String HWN = Console.ReadLine();
                if (HWN == "Hw_04_01")
                {
                    Hw_04_01();
                }
                else if (HWN == "Hw_04_02")
                {
                    Hw_04_02();
                }
                else if (HWN == "Hw_04_03")
                {
                    Hw_04_03();
                }
                else if (HWN == "Hw_04_04")
                {
                    Hw_04_04();
                }
                else if (HWN == "Hw_04_05")
                {
                    Hw_04_05();
                }
                else if (HWN == "Q")
                {
                    Console.WriteLine("程式已結束感謝使用");
                    break;
                }
                else if (HWN == "Hw_05_03")
                {
                    Hw_05_03();
                }
                else if (HWN == "Hw_05_04")
                {
                    Hw_05_04();
                }
                else if (HWN == "Hw_05_05")
                {
                    Hw_05_05();
                }
                else if (HWN == "Hw_05_06")
                {
                   Hw_05_06();
                }
                else if (HWN == "Hw_05_07")
                {
                    Hw_05_07();
                }
                else if (HWN == "Hw_05_08")
                {
                    Hw_05_08();
                }
                else if (HWN == "Hw_06_02")
                {
                    Hw_06_02();
                }
                else if (HWN == "Hw_06_03")
                {
                    Hw_06_03();
                }
                else
                {
                    Console.WriteLine("未找到對應作業名稱");
                }
            }
        }

        private void Hw_04_01()
        {
            Console.WriteLine("請輸入希望的階層");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            for (int i = 0; i <= num; i++)
            {
                string output = "";
                for (int j = 0; j < num - i; j++)
                {

                    output += " ";

                }
                for (int j = 1; j <= i; j++)
                {
                    output += "*";

                }

                Console.WriteLine(output);
            }
        }
        private void Hw_04_02()
        {
            Vector2 player1 = new Vector2(1, 2);
            Vector2 player2 = new Vector2(3, 5);
            Vector2 sum = player1.Add(player2);
            Vector2 product = player1.Multiply(player2);
            Console.WriteLine($"Sum: {sum.ToStringRepresentation()}");
            Console.WriteLine($"Product: {product.ToStringRepresentation()}");

        }

        private void Hw_04_03()
        {
            Vector2 player1 = new Vector2(1, 2);
            Vector2 player2 = new Vector2(3, 5);
            float dis = player1.dis(player2);
            Console.WriteLine(dis);
        }

        private void Hw_04_04()
        {
            // 建立向量 (6, 8)
            Vector2 player1 = new Vector2(6, 8);

            // 計算正規化向量
            Vector2 normalized = player1.Normalize();

            // 輸出結果
            Console.WriteLine($"Original Vector: ({player1.X}, {player1.Y})");
            Console.WriteLine($"Normalized Vector: ({normalized.X}, {normalized.Y})");
        }

        private void Hw_04_05()
        {
            player player1 = new player();
            player1.SetHp(100);
            player1.position = new Vector2(0, 0);
            player player2 = new player();
            player2.SetHp(0);
            player2.position = new Vector2(4, 3);
            player1.playerinform();
            player2.playerinform();
            float distance = player1.position.dis(player2.position);
            Console.WriteLine($"兩個玩家之間的距離：{distance}");

        }
        public void Hw_05_03()
        {
            // 建立 3 個 Counter 物件
            Counter1 counter1 = new Counter1();
            Counter1 counter2 = new Counter1();
            Counter1 counter3 = new Counter1();

            // 呼叫 GetCounter 方法並輸出結果
            Console.WriteLine(counter1.GetCounter()); // 預期輸出 1
            Console.WriteLine(counter2.GetCounter()); // 預期輸出 1
            Console.WriteLine(counter3.GetCounter()); // 預期輸出 1
        }
        public void Hw_05_04()
        {
            // 建立 3 個 Counter 物件
            Counter2 counter1 = new Counter2();
            Counter2 counter2 = new Counter2();
            Counter2 counter3 = new Counter2();

            // 呼叫 GetCounter 方法並輸出結果
            Console.WriteLine(counter1.GetCounter()); // 預期輸出 3
            Console.WriteLine(counter2.GetCounter()); // 預期輸出 3
            Console.WriteLine(counter3.GetCounter()); // 預期輸出 3
        }
            public void Hw_05_05()
            {
            // 建立 3 個 Counter 物件，並在每次建構時調用 GetCounter
            Counter3 counter1 = new Counter3();
            Console.WriteLine(Counter3.GetCounter()); // 預期輸出 1

            Counter3 counter2 = new Counter3();
            Console.WriteLine(Counter3.GetCounter()); // 預期輸出 2

            Counter3 counter3 = new Counter3();
            Console.WriteLine(Counter3.GetCounter()); // 預期輸出 3
            }
        public void Hw_05_06()
        {
            // 使用 HW_05.Vector2
            Vector2_05 vector1 = new Vector2_05(3, 4);
            Vector2_05 vector2 = new Vector2_05(1, 2);

            // 測試 Add
            Vector2_05 sum = Vector2Utility.Add(vector1, vector2);
            Console.WriteLine($"向量和：{sum}");

            // 測試 Multiply
            Vector2_05 product = Vector2Utility.Multiply(vector1, vector2);
            Console.WriteLine($"向量積：{product}");

            // 測試 Dot
            float dotProduct = Vector2Utility.Dot(vector1, vector2);
            Console.WriteLine($"向量內積：{dotProduct}");

            // 測試 Distance
            float distance = Vector2Utility.Distance(vector1, vector2);
            Console.WriteLine($"向量距離：{distance}");

            // 測試 Magnitude
            float magnitude = Vector2Utility.Magnitude(vector1);
            Console.WriteLine($"向量長度：{magnitude}");

            // 測試 Normalize
            Vector2_05 normalized = Vector2Utility.Normalize(vector1);
            Console.WriteLine($"向量正規化：{normalized}");
        }

        public void Hw_05_07()
        {
            Hw_05_Student_1.Student studentA = new Hw_05_Student_1.Student();
            studentA.id = 123;
            studentA.Name = "Steven";
            Hw_05_Student_1.Student studentB = new Hw_05_Student_1.Student();
            studentB.id = 456;
            studentB.Name = "Marco";
            Console.WriteLine($"Student A -> ID: {studentA.id}, Name: {studentA.Name}");
            Console.WriteLine($"Student B -> ID: {studentB.id}, Name: {studentB.Name}");

        }

        public void Hw_05_08()
        {
            // 宣告並初始化 studentA
            Hw_05_Student_2.Student studentA = new Hw_05_Student_2.Student();
            studentA.id = 123;
            studentA.Name = "Steven";

            // 將 studentA 賦值給 studentB
            Hw_05_Student_2.Student studentB = studentA;

            // 修改 studentB 的屬性
            studentB.id = 456;
            studentB.Name = "Marco";

            // 輸出兩個學生的資訊
            Console.WriteLine($"Student A -> ID: {studentA.id}, Name: {studentA.Name}");
            Console.WriteLine($"Student B -> ID: {studentB.id}, Name: {studentB.Name}");
        }

        public void Hw_06_02()
        {
            Player player = new Player("勇者", 5.0f, 10);
            Enemy enemy = new Enemy("黑暗騎士", 3.5f, 20.0f);
            Npc npc = new Npc("商人", 2.0f, "歡迎來到商店！");
            // 宣告 Character 類型變數，有找教學參考
            Character character;

            character = player;
            character.Move();
            character.Attack();
            character.CastSkill();
            character = enemy;
            character.Move();
            character.Attack();
            character.CastSkill();
            character = npc;
            character.Move();
            character.Attack(); // 父類別方法
            character.CastSkill();
        }

        public void Hw_06_03()
        {
            Player player = new Player("勇者", 5.0f, 10);
            Enemy enemy = new Enemy("黑暗騎士", 3.5f, 20.0f);
            Npc npc = new Npc("商人", 2.0f, "歡迎來到商店！");
            Hw_06_03_TestCharacter(player);
            Hw_06_03_TestCharacter(enemy);
            Hw_06_03_TestCharacter(npc);
        }
        public void Hw_06_03_TestCharacter(Character character)//這裡有點困惑
        {
            character.Move();
            character.Attack();
            character.CastSkill();

        }

    }
}
