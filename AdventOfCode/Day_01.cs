using System;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace AdventOfCode;

public class Day_01 : BaseDay
{
    private readonly string _input;

    public Day_01()
    {
        _input = File.ReadAllText(InputFilePath);

        int Increment()
        {
            int[] input = { };
            int increaseAmount = 0;
            input = Array.ConvertAll (File.ReadAllLines (InputFilePath), x => int.Parse (x));
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] < input[i + 1])
                    increaseAmount++;
            }
            return increaseAmount;
        }
        
        Console.WriteLine(Increment());
    }

    public override ValueTask<string> Solve_1() => new("Solution 1 1616");

    public override ValueTask<string> Solve_2() => new($"Solution to {ClassPrefix} {CalculateIndex()}, part 2");
}
