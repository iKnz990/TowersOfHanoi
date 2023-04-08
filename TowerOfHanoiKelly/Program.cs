using System;
/***************************************************************
* Name : Towers of Hanoi
* Author: Alexander Kelly
* Created : 1/30/2023
* Course: CIS 152 - Data Structure
* Version: 1.0
* OS: Windows 11
* IDE: Visual Studio 2019
* Copyright : Cannot copyright Academic Material.
* Description : Recursion. 
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.
***************************************************************/


/*
 Recursion is a when we use a method that calls itself to solve a problem. Using recursion we divide a problem into smaller 'sub-problems'. The solution to each problem is found recursively. It is an infinate loop that reaches its a condition that will stop it, which we call a base case.

I'm a gamer at heart. "Find your way home" is a game development concept.

In this Tower of Hanoi example, I made an example about recursion in gaming. This takes a problem, getting to the end of the game, and divides it into smaller problems, side quests. To eventually get the origin(Character) to the destination.
The Hanoi() takes the input number of disks 'n'[I keep this as N, because you can use it for anything] and names the source 'origin' and the destination 'destination' and the auxiliary 'sideQuest'. The method calls itself twice to solve the sub-problems of moving('n-1') your character('disks') from the origin to the sideQuests and then sideQuest to destination. Each call increments the count.

It's also useful when designing a video game... Level Design, Character Generation, Combat Mechanics, Quest Design, and Inventory management are good examples.
 */

namespace TowerOfHanoiKelly
{
    class Program // Big O = O(2^n) where n = Input # of Disks.
    {
        static int count = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of disks: ");
            int n = int.Parse(Console.ReadLine());
            Hanoi(n, 'A', 'B', 'C');
            Console.WriteLine(n + " disks require " + count + " moves");
        }

        static void Hanoi(int n, char origin, char destination, char sideQuest)
        {
            if (n == 1)
            {
                count++;
                return;
            }
            Hanoi(n - 1, origin, sideQuest, destination);
            count++;
            Hanoi(n - 1, sideQuest, destination, origin);
        }
    }
}

