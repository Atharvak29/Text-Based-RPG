using System;

namespace Game
{
    class PathOfMorality
    {
        public void Morality(Player player)
        {
            if (player.POM == true)
            {
                Console.WriteLine("You have already completed this path");
                Console.WriteLine("\nPress any key to return to the central chamber...");
                Console.ReadKey();
                return;
            }

            Console.Clear();
            Console.WriteLine(
                @"You find a wounded villager chained beside a pedestal.

On the pedestal lies a gleaming enchanted sword.

Villager:
""Please... help me. I've been trapped for days.""

A voice echoes:
""You may take the sword... or free the soul.""

1. Take the sword (Gain powerful weapon)
2. Free the villager (Gain ally in final fight)"
            );

            int option_chossen;

            while (true)
            {
                string? input = Console.ReadLine();

                if (
                    int.TryParse(input, out option_chossen)
                    && (option_chossen == 1 || option_chossen == 2)
                )
                {
                    if (option_chossen == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(
                            @"You grip the sword. Power courses through your veins.

Villager:
""...I... I trusted you...""

He vanishes. A chill settles on your heart.

[You return to the central chamber.]


Press any key to return to the central chamber...
"
                        );
                        player.POM = true;
                        Console.ReadKey();
                        return;
                    }
                    else if (option_chossen == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(
                            @"Voice: ""You break the chains.

Villager:
""Thank you, Eryn... I’ll stand by your side when you need me.""

[You return to the central chamber.]

Press any key to return to the central chamber...
"
                        );
                        player.POM = true;
                        Console.ReadKey();
                        return;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter 1, or 2\n");
                }
            }
        }
    }
}
