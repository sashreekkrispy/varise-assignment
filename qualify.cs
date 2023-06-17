using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the total points required to qualify (X):");
        int pointsRequired = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of matches (Y):");
        int numMatches = int.Parse(Console.ReadLine());

        int winsNeeded = CalculateWinsNeeded(pointsRequired, numMatches);
        Console.WriteLine("The minimum number of wins needed to qualify: " + winsNeeded);
    }

    static int CalculateWinsNeeded(int pointsRequired, int numMatches)
    {
        int maxPointsPossible = numMatches * 2;
        int winsNeeded = (pointsRequired - maxPointsPossible) / 3;

        if ((pointsRequired - maxPointsPossible) % 3 != 0)
        {
            winsNeeded++;
        }

        return winsNeeded;
    }
}

