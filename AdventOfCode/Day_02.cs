using System;
using System.Collections.Generic;
using System.Linq;

public class Day_02 : BaseDay
{
    private readonly string[] _input;

    public Day_02()
    {
        _input = File.ReadAllLines(InputFilePath);
    }
    
    public override ValueTask<string> Solve_1()
    {
        int depth = 0;
        int postition = 0;
        foreach (string line in _input) 
        {
            string[] parts = line.Split(" ");
            if (parts[0] == "forward")
            {
                postition += Int32.Parse(parts[1]);
            }
            else if (parts[0] == "up")
            {
                depth -= Int32.Parse(parts[1]);
            }
            else if (parts[0] == "down") 
            {
                depth += Int32.Parse(parts[1]);
            }
        }
        return new((depth * postition).ToString());
    }
    
    public override ValueTask<string> Solve_2()
    {
        int depth = 0;
        int postition = 0;
        int aim = 0;
        foreach (string line in _input)
        {
            string[] parts = line.Split(" ");
            if (parts[0] == "forward")
            {
                int newPostion = Int32.Parse(parts[1]);
                depth += newPostion * aim;
                postition += newPostion;
            }
            else if (parts[0] == "up")
            {
                aim -= Int32.Parse(parts[1]);
            }
            else if (parts[0] == "down")
            {
                aim += Int32.Parse(parts[1]);
            }
        }
        return new((depth * postition).ToString());
    }
    
}