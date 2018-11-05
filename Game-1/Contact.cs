using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_1
{
    class Contact
    {
        //У варвара не отнимается здоровье
        Random r = new Random();
        public void Barbarian()
        {
            int HP = 100;
            int DM = 5;
            do
            {
            Console.Clear();
            Console.WriteLine("Бой с варваром");
            Console.WriteLine("Здоровье варвара "+ HP);
            Defend(HP);
            Console.Clear();
            Console.WriteLine("Бой с варваром");
            Console.WriteLine("Здоровье варвара " + HP);
            Attack(DM);
            } while (HP > 0);
            Console.WriteLine("Варвар погиб");
            Console.ReadKey();
        }
        void Defend(int HP)
        {            
            
            Console.WriteLine("1 - ударить ногой");
            Console.WriteLine("2 - ударить рукой");
            int f = Convert.ToInt32(Console.ReadKey().KeyChar);
            switch (f)
            {
                case 1: HP -= r.Next(20, 30);break;
                case 2: HP -= r.Next(20, 30); break;
            }
        }
        int Attack(int damage)
        {
            Console.WriteLine("1 - защитить голову");
            Console.WriteLine("2 - защитить тело");
            int v = r.Next(1, 2);
            int d = Convert.ToInt32(Console.ReadKey().KeyChar);
            if (v == d)
            {
                damage = r.Next(3, 7);
            }
            else
            {
                damage = r.Next(21, 31);
            }
            return damage;
        }
    }
}
