﻿using System;

class CheckForPlayCard
{
    static void Main()
    {
        string input = Console.ReadLine();
        switch (input)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "Q":
            case "K":
            case "A": Console.WriteLine("yes"); break;
            default: Console.WriteLine("no"); break;
        }
    }
}

