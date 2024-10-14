using System;
using System.Collections.Generic;
using System.Linq;

class PeshoReels {
    static void Main(string[] args) {
        int N = int.Parse(Console.ReadLine()); // allocated time in seconds
        int M = int.Parse(Console.ReadLine()); // number of reel length configurations

        List<int> reelLengths = new List<int>();
        for (int i = 0; i < M; i++) {
            reelLengths.Add(int.Parse(Console.ReadLine()));
        }

        string command = Console.ReadLine();

        if (command == "count") {
            Console.WriteLine(MinimumReels(N, reelLengths));
        } else if (command == "details") {
            Dictionary<int, int> reelCounts = ReelCounts(N, reelLengths);
            foreach (var kvp in reelCounts.OrderByDescending(kvp => kvp.Key)) {
                if (kvp.Value != 0)  
                    Console.WriteLine($"{kvp.Value} x {kvp.Key} seconds");
            }
        }
    }

    static int MinimumReels(int N, List<int> reelLengths) {
        int totalReels = 0;
        int remainingTime = N;

        foreach (int reelLength in reelLengths) {
            int reelsNeeded = remainingTime / reelLength;
            totalReels += reelsNeeded;
            remainingTime -= reelsNeeded * reelLength;
        }

        return totalReels;
    }

    static Dictionary<int, int> ReelCounts(int N, List<int> reelLengths) {
        Dictionary<int, int> reelCounts = new Dictionary<int, int>();
        int remainingTime = N;

        foreach (int reelLength in reelLengths) {
            int reelsNeeded = remainingTime / reelLength;
            reelCounts[reelLength] = reelsNeeded;
            remainingTime -= reelsNeeded * reelLength;
        }

        return reelCounts;
    }
}