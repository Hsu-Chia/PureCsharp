using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpTest.HW_06
{
    abstract class Character
    {
        protected string _name;
        protected float _moveSpeed;

        public Character(string name, float moveSpeed)
        {
            _name = name;
            _moveSpeed = moveSpeed;
        
        }
        public void Move()
        {
            Console.WriteLine($"{_name}正在以{_moveSpeed}移動");        
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{_name} 發起了一次攻擊！");
        }

        public abstract void CastSkill();
    }

    class Player:Character
    {
        protected int _level;
        public Player(string name,float moveSpeed, int Level) : base(name,moveSpeed)
        {
            _level = Level;
        }
        public override void Attack()
        {
            Console.WriteLine($"{_name} 使用了玩家專屬攻擊！ 等級加成：{_level * 5} 點傷害");
        }

        public override void CastSkill()
        {
            Console.WriteLine($"{_name} 使用了玩家技能：劍氣橫掃！ 等級加成：{_level * 10} 點傷害");
        }
    }

    class Enemy : Character
    {
        protected float _attackPower;
        public Enemy(string name, float moveSpeed, float attackPower) : base(name, moveSpeed)
        {
            _attackPower = attackPower;
        }
        public override void Attack()
        {
            Console.WriteLine($"{_name} 發動了一次強力攻擊！ 攻擊力為 {_attackPower}。");
        }

        public override void CastSkill()
        {
            Console.WriteLine($"{_name} 使用了敵方技能：黑暗之刃！ 攻擊力為 {_attackPower * 2}");
        }

    }

    class Npc : Character
    {
        protected string _dialogue;
        public Npc (string name, float moveSpeed, string dialogue) : base(name, moveSpeed)
        {
            _dialogue = dialogue;
        }
        public override void CastSkill()
        {
            Console.WriteLine($"{_name} 提供了幫助：{_dialogue}");
        }


    }
}
