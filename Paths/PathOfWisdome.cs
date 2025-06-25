using System;
using RPG.Game;

namespace RPG.Paths
{
    class PathOfWisdome
    {
        public void Wisdom(Player player)
        {
            if (player.POW == true)
            {
                Console.WriteLine("You have already completed this path");
                Console.WriteLine("\nPress any key to return to the central chamber...");
                Console.ReadKey();
                return;
            }

            Console.Clear();
            Console.WriteLine(
                @"You enter a silent chamber. An ancient voice booms from the stone.

Voice:
""Only the wise shall pass. Speak truth, and the way will open.""

Riddle:
""I speak without a mouth and hear without ears.
I have no body, but I come alive with the wind. What am I?""

Your answer: ______"
            );

            string ans = (Console.ReadLine() ?? "").ToLower();

            if (ans == "echo")
            {
                Console.Clear();
                Console.WriteLine(
                    @"Voice: ""Wisdom shines within you, Eryn. Proceed.""

A second rune glows. You feel clarity in your mind.

[You return to the central chamber.]

Press any key to return to the central chamber...
"
                );
                player.POW = true;
                Console.ReadKey();
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(
                    @"Voice: ""Your mind wavers. Return when you are ready.""

[Trial fails. No bonus. You return to the central chamber.]

Press any key to return to the central chamber...
"
                );
                player.POW = true;
                Console.ReadKey();
                return;
            }
        }
    }
}
