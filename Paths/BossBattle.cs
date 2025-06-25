using System;
using RPG.Game;

namespace RPG.Paths
{
    class BossBattle
    {
        //BOSS STATS
        int Boss_strength = 15;
        int Boss_Health = 100;

        public void Boss(Player player)
        {
            Console.WriteLine(
                @"The runes glow. The path forward reveals itself.
You step into the final chamber.

A swirling shadow rises from the altar...

Cursed Spirit:
""So... you have come, bearer of courage. But are you worthy?""

[Battle begins]

Press any key to being the battle
"
            );
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"\n⚔️ A battle begins between YOU and THE FINAL BOSS!!\n");

            Console.WriteLine($"DEBUG: Player HP = {player.Health}, Boss HP = {Boss_Health}");

            while ((player.Health > 0) && (Boss_Health > 0))
            {
                // Player Turn
                Console.WriteLine("Your Turn:");
                Console.WriteLine("1. Attack");
                Console.Write("Choose action: ");
                string? input = Console.ReadLine();
                if (input == "1")
                {
                    Boss_Health = Boss_Health - player.Strength;
                    Console.WriteLine($"Your HP: {player.Health} | Boss HP: {Boss_Health}");
                }
                else
                {
                    Console.WriteLine("Invalid action. You lose your turn.");
                    Console.WriteLine($"Your HP: {player.Health} | Boss HP: {Boss_Health}");
                }
                if (Boss_Health <= 0)
                {
                    Console.Clear();
                    Console.WriteLine($"\nYou defeated the Boss!");
                    Console.WriteLine(
                        @"With one final blow, the Cursed Spirit shatters.

Light returns to the caverns.

Narrator:
""Eryn, bearer of wisdom, strength, and compassion — you have lifted the curse.""

The villagers of Eldwyn welcome you as a hero.

Press any key to end the game......
"
                    );
                    Console.ReadLine();
                    player.BB = true;
                    // Console.WriteLine($"\n\nYour HP: {player.Health} | Boss HP: {Boss_Health}");
                    Environment.Exit(0);
                }

                Console.WriteLine($"\nBoss's Turn:");
                player.Health = player.Health - Boss_strength;
                Console.WriteLine($"Your HP: {player.Health} | Boss HP: {Boss_Health}");

                if (player.Health <= 0)
                {
                    Console.WriteLine(
                        @"\n💀 You have been slain...YOU HAVE DISAPOINTED YOUR ELDERS

                        Press any key to end the game"
                    );

                    // Console.WriteLine($"Your HP: {player.Health} | Boss HP: {Boss_Health}");
                    Console.ReadLine();
                    player.BB = true;
                    Environment.Exit(0);
                }

                Console.WriteLine("\n--- Next Round ---\n");
            }
        }
    }
}
