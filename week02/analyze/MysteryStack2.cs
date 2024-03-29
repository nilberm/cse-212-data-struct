﻿/*
 * CSE212 
 * (c) BYU-Idaho
 * 03-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code
 * with others or to post it online.  Storage into a personal and private
 * repository (e.g. private GitHub repository, unshared Google Drive
 * folder) is acceptable.
 */

// result = 50
// result = 4
public static class MysteryStack2
{
    private static bool IsFloat(string text)
    {
        return float.TryParse(text, out _);
    }

    public static float Run(string text)
    {
        var stack = new Stack<float>();
        foreach (var item in text.Split(' '))
        {
            if (item == "+" || item == "-" || item == "*" || item == "/")
            {
                if (stack.Count < 2)
                    throw new ApplicationException("Invalid Case 1!");

                var op2 = stack.Pop();
                var op1 = stack.Pop();
                float res;
                if (item == "+")
                {
                    res = op1 + op2;
                }
                else if (item == "-")
                {
                    res = op1 - op2;
                }
                else if (item == "*")
                {
                    res = op1 * op2;
                }
                else
                {
                    if (op2 == 0)
                        throw new ApplicationException("Invalid Case 2!");

                    res = op1 / op2;
                }

                stack.Push(res);
            }
            else if (IsFloat(item))
            {
                stack.Push(float.Parse(item));
            }
            else if (item == "")
            {
            }
            else
            {
                throw new ApplicationException("Invalid Case 3!");
            }
        }

        if (stack.Count != 1)
            throw new ApplicationException("Invalid Case 4!");

        return stack.Pop();
    }
}