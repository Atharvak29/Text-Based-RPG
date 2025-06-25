using System;
using Game;

namespace MyApplication
{
    class PathOfFury
    {
        // Player player = new Player();
        int GoblineKing_Stength = 10;
        int GoblineKing_Health = 70;

        public void Fury(Player player)
        {
            if (player.POF == true)
            {
                Console.WriteLine("You have already completed this path");
                Console.WriteLine("\nPress any key to return to the central chamber...");
                Console.ReadKey();
                return;
            }
            Console.WriteLine(
                @"
You walk into a tunnel lit by flickering torches.
A guttural roar echoes through the darkness.

Goblin King:
""Another mortal dares challenge me? You'll feed the rats tonight!""

[Battle begins – turn-based combat]

Press any key to begin battle..."
            );

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"\n⚔️ A battle begins between YOU and GOBLINE!\n");

            Console.WriteLine(
                $"DEBUG: Player HP = {player.Health}, Goblin HP = {GoblineKing_Health}"
            );

            while ((player.Health > 0) && (GoblineKing_Health > 0))
            {
                // Player Turn
                Console.WriteLine("Your Turn:");
                Console.WriteLine("1. Attack");
                Console.Write("Choose action: ");
                string? input = Console.ReadLine();
                if (input == "1")
                {
                    GoblineKing_Health = GoblineKing_Health - player.Strength;
                    Console.WriteLine(
                        $"Your HP: {player.Health} | Goblin HP: {GoblineKing_Health}"
                    );
                }
                else
                {
                    Console.WriteLine("Invalid action. You lose your turn.");
                    Console.WriteLine(
                        $"Your HP: {player.Health} | Goblin HP: {GoblineKing_Health}"
                    );
                }
                if (GoblineKing_Health <= 0)
                {
                    Console.Clear();
                    Console.WriteLine($"\nYou defeated the Gobline!");
                    Console.WriteLine(
                        @"Goblin King: ""Hrrgh... you're... stronger than you look...""
He falls, defeated. A glowing rune appears on the wall.

You feel a surge of strength. Your resolve deepens.

[You return to the central chamber.]"
                    );

                    Console.WriteLine(
                        $"\n\nYour HP: {player.Health} | Goblin HP: {GoblineKing_Health}"
                    );
                    break;
                }

                Console.WriteLine($"\nGobline's Turn:");
                player.Health = player.Health - GoblineKing_Stength;
                Console.WriteLine($"Your HP: {player.Health} | Goblin HP: {GoblineKing_Health}");

                if (player.Health <= 0)
                {
                    Console.WriteLine("\n💀 You have been slain...");
                    Console.WriteLine(
                        $"Your HP: {player.Health} | Goblin HP: {GoblineKing_Health}"
                    );

                    break;
                }

                Console.WriteLine("\n--- Next Round ---\n");
            }

            player.POF = true;
        }
    }
}
