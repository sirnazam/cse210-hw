
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of my day?",
        "Who was the most interesting person I interacted with today?",
        "What am I grateful for today?",
        "What did I learn today?",
        "What was the strongest emotion I felt today?",
        "What is something I would like to improve about myself?",
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int number = random.Next(_prompts.Count);

        return _prompts[number];
    }
}
