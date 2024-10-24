﻿using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Develop04;


/*
Think of a time when you stood up for someone else.
Think of a time when you did something really difficult.
Think of a time when you helped someone in need.
Think of a time when you did something truly selfless.
*/
public class ReflectionActivity : ActivityClass
{
    private int _duration;
    private string _name = "Reflection Activity";

    private string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    private List<string> _promptlist = new() { "Think of a time when you did something truly selfless.", "Think of a time when you helped someone in need.", "Think of a time when you did something really difficult.", "Think of a time when you stood up for someone else." };

    private List<string> _promptquestions = new() { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
    private Random _random = new();

    private void ReflectionSession(int duration)
    {
        Console.Clear();
        StartingMessage(_name, _description);
        Console.Write("Please wait......");
        SpinnerAnimation(0, 4);
        Console.WriteLine();

        string word = PickFromList(_promptlist);
        Console.WriteLine($"-----{word}-----");
        Console.Write("Press enter to continue");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
        Console.Write("You may begin in: ");
        CountDown(5);
        Console.WriteLine();
        Console.Clear();

        Stopwatch stopwatch = new();
        stopwatch.Start();

        List<string> shuffledQuestions = _promptquestions.OrderBy(x => _random.Next()).ToList();

        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < duration && shuffledQuestions.Count > 0)
        {
            string question = shuffledQuestions[0];
            shuffledQuestions.RemoveAt(0);
            
            Console.Write($"> {question}");
            SpinnerAnimation(0, 3);
            Console.WriteLine();
        }

        stopwatch.Stop();
        SpinnerAnimation(0, 3);
        EndingMessage(duration, _name);
        SpinnerAnimation(0, 3);
        Console.Clear();
    }

    public void RunTheActivity(int duration)
    {
        ReflectionSession(duration);
    }
}