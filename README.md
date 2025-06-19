# 🎮 Game Title: “Cursed Caverns: The Trial of Valor”
---

## 🧙 Story Premise
You are **Eryn**, a young adventurer from the peaceful village of Eldwyn. After a mysterious darkness spreads from the nearby Cursed Caverns, you are chosen to uncover its source. Inside, you must face trials of combat, wisdom, and character, guided only by your choices and instincts.

Your goal: **Defeat the ancient cursed spirit and lift the darkness.**

---

## 🧱 Game Structure

### 🌟 Game Progression
1.  **Intro**
2.  **Character Setup**
3.  **Cavern Entrance**
4.  **Three Paths (Branches)**
    * Combat Trial: Battle Goblin King
    * Wisdom Trial: Solve a riddle
    * Morality Trial: Make a difficult choice
5.  **Final Boss Fight**
6.  **Ending** (based on choices)

---

## 🎬 Game Flow Overview

1.  **Intro Scene**

    ```css
    Welcome to Cursed Caverns: The Trial of Valor
    You are Eryn, the chosen hero of Eldwyn...
    ```

2.  **Character Setup**

    ```csharp
    Choose your class:
    1. Warrior (High Health, Medium Attack)
    2. Mage (Low Health, High Magic)
    3. Rogue (Medium Health, High Dodge)
    Initialize player stats accordingly.
    ```

3.  **Cavern Entrance**
    Player decides which path to explore first:

    ```pgsql
    You stand before three tunnels.
    1. Path of Fury (Combat)
    2. Path of Knowledge (Riddle)
    3. Path of Sacrifice (Moral Trial)
    ```

    Each branch is a self-contained function you write.

4.  **The Three Trials**

    * **⚔️ Combat Trial** – Fight a Goblin King
        * Turn-based battle
        * Use attacks or heal
        * Win or lose based on choices/stats

    * **🧠 Wisdom Trial** – Solve a riddle
        * "I speak without a mouth and hear without ears. I have no body, but I come alive with the wind. What am I?"
        * Answer: **echo**

    * **💔 Morality Trial** – Save a trapped villager or take a magical sword
        * **Save** → You gain help in final battle
        * **Take sword** → You get strong attack boost

5.  **Final Battle** – Cursed Spirit
    * Boss changes behavior based on which trials you passed
    * Branching dialogue + multiple endings

---

## 🏁 Endings

* **True Ending** – Passed all 3 trials with noble heart → Lift the curse.
* **Power Ending** – Took sword, used strength → Win, but become new curse.
* **Bad Ending** – Failed or ran away from trials → Eldwyn consumed.

---

## 🔧 C# Concepts You'll Practice

* `class Player`, `class Enemy`
* `switch-case` and `if-else`
* Loops for combat
* User input with `Console.ReadLine()`
* Random numbers (for damage, dodge)
* Method structuring for trials
* Object-oriented structure (inheritance if you expand)

---

## 🛠 Bonus Ideas for Expansion

* Inventory system (Potions, gear)
* XP and leveling up
* Save/load game with file handling
* ASCII map or health bar
* Modular code using multiple files/classes
