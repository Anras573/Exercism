﻿namespace Exercism.RomanNumerals;

public static class RomanNumeralExtension
{
    private static readonly Dictionary<int, string> RomanNumerals = new()
    {
        { 1000, "M" },
        { 900, "CM" },
        { 500, "D" },
        { 400, "CD" },
        { 100, "C" },
        { 90, "XC" },
        { 50, "L" },
        { 40, "XL" },
        { 10, "X" },
        { 9, "IX" },
        { 5, "V" },
        { 4, "IV" },
        { 1, "I" }
    };
    
    public static string ToRoman(this int value)
    {
        var result = "";
        
        foreach (var numeral in RomanNumerals)
        {
            while (value >= numeral.Key)
            {
                result += numeral.Value;
                value -= numeral.Key;
            }
        }
        
        return result;
    }
}