using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int Pos = 0;
        int Neg = 0;
        int Zero = 0;
        var arrayLen = arr.Count;

        foreach (var num in arr)
        {
            if (num > 0)
            {
                Pos++;
            }
            else if (num < 0)
            {
                Neg++;
            }
            else
            {
                Zero++;
            }
        }

        double ResPos = (double)Pos / arrayLen;
        double ResNeg = (double)Neg / arrayLen;
        double ResZero = (double)Zero / arrayLen;

        Console.WriteLine($"{ResPos:F6}\n{ResNeg:F6}\n{ResZero:F6}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}