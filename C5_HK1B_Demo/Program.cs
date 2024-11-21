using C5_HK1B_Demo.BeeGame;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_HK1B_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Game game = new Game();

            while (true)
            {
                Console.WriteLine("1. Tan cong");
                Console.WriteLine("2. Xuat thong tin");
                Console.WriteLine("3. Thoat");
                Console.Write("Chon: ");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        game.AttackBees();
                        break;
                    case 2:
                        game.PrintBees();
                        break;
                    case 3:
                        return;
                }
            }
        }
    }
}
