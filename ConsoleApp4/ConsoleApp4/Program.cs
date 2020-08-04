using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {       
            chara charaInstance = new chara();
            chara enemyInstance = new chara();
            

            Console.WriteLine("Q = 攻撃, W = 回復, E = 敵の攻撃力を減らす, R = 自分の攻撃力を強化");

            while (charaInstance.HP < 0 && enemyInstance.HP < 0)
            {
                Console.ReadLine();
                if (Console.ReadKey().Key == ConsoleKey.Q)
                {
                    charaInstance.Attack(enemyInstance);                
                }
                else if (Console.ReadKey().Key == ConsoleKey.W)
                {
                    charaInstance.Heal(charaInstance);
                }
                else if (Console.ReadKey().Key == ConsoleKey.E)
                {
                    charaInstance.weaken(enemyInstance);
                }
                else if (Console.ReadKey().Key == ConsoleKey.R)
                {
                    charaInstance.Strength(enemyInstance);
                }
            }
        }
    }
}
