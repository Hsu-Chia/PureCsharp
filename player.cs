using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpTest
{
    //傳入一個Vector2移動玩家的方法 不知道怎麼寫
    class player
    {
        private int _hp;
        private Vector2 _position;

        public int GetHp()
        {
            return _hp;
        }
        public void SetHp(int value)
        {
            _hp = value;
            if (_hp <= 0)
            {
                _hp = 0;
                Console.WriteLine("玩家已經死亡");

            }

        }
        public Vector2 position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }
        public void playerinform()
        {
            Console.WriteLine("player現在的位置為" + _position + "血量為" + _hp);
        }
    }
}
