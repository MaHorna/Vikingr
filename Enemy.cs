using System;
using System.Collections.Generic;
using System.Text;

namespace Vikingr
{
    class Enemy
    {
        public static Enemy[] Enemies = new Enemy[100];
        public string Name;
        public int Type;
        public int Damage;
        public int Health;
        public double Armour;
        public Item[] Lootable;
        public int[] Stats;


        public Enemy(string EnemyName, int EnemyType, int EnemyDamage, int EnemyHealth, int EnemyArmour, Item[] EnemyLootable, int[] EnemyStats)
        {
            this.Name = EnemyName;
            this.Type = EnemyType;
            this.Damage = EnemyDamage;
            this.Health = EnemyHealth;
            this.Armour = EnemyArmour;
        }
    }
}
