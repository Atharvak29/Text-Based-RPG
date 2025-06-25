using System;
using System.Security.Cryptography.X509Certificates;
using MyApplication;

namespace Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Intro intro = new Intro();
            intro.ShowIntro();

            Player player = new Player();

            int heroClass;
            while (true)
            {
                intro.heroClass();

                string? input = Console.ReadLine();

                if (
                    int.TryParse(input, out heroClass)
                    && (heroClass == 1 || heroClass == 2 || heroClass == 3)
                )
                {
                    player.Class = heroClass;
                    break; // valid input
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.\n");
                }
            }
            Console.Clear();
            Console.WriteLine("You Choose Class " + player.Class);

            if (player.Class == 1) //Warrior (High Health, Medium Attack)
            {
                player.Health = 150;
                player.Strength = 20;
            }
            if (player.Class == 2) //Mage (Low Health, High Magic)
            {
                player.Health = 80;
                player.Strength = 5;
            }
            if (player.Class == 3) //Rogue (Medium Health, High Dodge)
            {
                player.Health = 100;
                player.Strength = 15;
            }

            while (true)
            {
                int Enterence;
                while (true)
                {
                    intro.Enterence();

                    string? input = Console.ReadLine();

                    if (
                        int.TryParse(input, out Enterence)
                        && (Enterence == 1 || Enterence == 2 || Enterence == 3)
                    )
                    {
                        player.Enterence = Enterence;
                        break; // valid input
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.\n");
                    }
                }
                Console.Clear();
                Console.WriteLine("You choose Enterence " + player.Enterence);

                if (player.Enterence == 1) //Path of Fury (Combat Trial)
                {
                    PathOfFury fury = new PathOfFury();
                    fury.Fury(player);
                }
                if (player.Enterence == 2) //Path of Knowledge (Wisdom Trial)
                {
                    PathOfWisdome Wisdom = new PathOfWisdome();
                    Wisdom.Wisdom(player);
                }
                if (player.Enterence == 3) //Path of Sacrifice (Morality Trial)
                {
                    PathOfMorality morality = new PathOfMorality();
                    morality.Morality(player);
                }
            }

            if (player.POF == true && player.POW == true && Player.POM == true)
            {
                // Console.WriteLine("Start boss battle");
                BossBattle bb = new BossBattle();
                bb.Boss(player);
            }
        }
    }
}
