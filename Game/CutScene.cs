using System;

namespace RPG.Game
{
    public class Intro
    {
        // To start the game and hide the dialoge from the main game file
        public void ShowIntro()
        {
            // Title Screen
            Console.WriteLine(
                @"[Title Screen]
🗡️ CURSED CAVERNS: THE TRIAL OF VALOR 🗡️

Press any key to begin..."
            );

            Console.ReadKey(); // Wait for input

            Console.Clear(); //clears the screen

            //Dialouge
            Console.WriteLine(
                @"Narrator:
In the peaceful village of Eldwyn, darkness stirs once more.
The elders have chosen YOU — Eryn, the bravest soul among them — to uncover the mystery in the Cursed Caverns.

Will you emerge a hero... or fall to the shadows?

Press any key to continue..."
            );

            Console.ReadKey();

            Console.Clear();

            //Dark Village ASCII art
            Console.WriteLine(
                @"⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⡿⠋⠉⠻⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣟⣋⣀⣀⣀⣀⣀⣙⣿⣿⡿⠛⢿⣿⣿⣿⣿⣿⣿⠟⠉⠈⠛⢿⣿⣿⣿⣿
⣿⣿⣿⡏⢉⡉⠉⠉⢉⣽⠿⠋⠀⠀⠀⠙⠿⣿⣿⣛⣁⣀⣀⣀⣀⣀⣙⣿⣿⣿
⣿⣿⣿⡇⠈⠁⣠⣴⠟⠁⠀⠀⠀⠀⠀⠀⠀⠈⠻⣿⡉⢉⡉⠉⠉⠉⢹⣿⣿⣿
⣿⣿⣿⣷⣶⣾⣿⣷⣶⢶⣶⠶⠶⠶⠶⠶⠶⠶⢶⣾⠿⠾⠁⠀⠀⣿⢸⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠙⢷⣄⡀⢰⣿⣷⠀⢸⣿⣿⡿⢿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⡿⠋⠀⠀⠀⠀⠙⠻⣦⡀⠀⢀⣼⠟⠁⠀⠀⠙⢿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⠟⠉⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⢷⣏⠁⠀⠀⠀⠀⠀⠀⠈⠻⣿⣿⣿
⣿⣿⣛⣁⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣙⣷⣶⣶⠶⠶⠶⠶⠶⢶⣶⣿⣿
⣿⣿⣿⣿⠋⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⢹⡏⠉⠉⠉⣀⣀⣀⠀⠀⢸⣿⣿⣿
⣿⣿⣿⣿⠀⠀⣶⣶⣶⠀⠀⢀⣀⣀⡀⠀⢸⡇⠀⠀⠀⣿⣿⣿⠀⠀⢸⣿⣿⣿
⣿⣿⣿⣿⠀⠀⠿⠿⠿⠀⠀⢸⣿⣿⡇⠀⢸⣇⣀⣀⣀⣿⣿⣿⣀⣀⣸⣿⣿⣿
⣿⣿⣿⣿⡀⠀⠀⠀⠀⠀⠀⢸⣿⣿⡇⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿

Press any key to continue..."
            );

            Console.ReadKey();
            Console.Clear();
        }

        // To pick a hero class in a loop
        public void heroClass()
        {
            // Choosing Class
            Console.WriteLine(
                @"It's time to Choose your class:
1. 🛡️ Warrior (High Health, Medium Attack)
2. 🔮 Mage (Low Health, High Magic)
3. 🗡️ Rogue (Medium Health, High Dodge)

Enter 1, 2, or 3:
 "
            );
        }

        public void Enterence()
        {
            Console.WriteLine(
                @"You stand before the yawning mouth of the Cursed Caverns.
A chilling wind whispers your name...

Three paths lie ahead:

1. Path of Fury (Combat Trial)
2. Path of Knowledge (Wisdom Trial)
3. Path of Sacrifice (Morality Trial)

Which do you choose first?
"
            );
        }
    }
}
