﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07_Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            var outputDict = new Dictionary<string, List<string>>();

            string pattern = @"([^&?]+)=([^&?]+)";
            var regex = new Regex(pattern);

            string input = Console.ReadLine();

            while (input != "END")
            {

                var matches = regex.Matches(input);

                foreach (Match match in matches)
                {

                    string currentKey = ExtractKey(match.Groups[1].Value.ToString());
                    string currentValue = ExtractValue(match.Groups[2].Value.ToString());

                    if (!outputDict.ContainsKey(currentKey))
                    {
                        outputDict[currentKey] = new List<string>();
                    }

                    outputDict[currentKey].Add(currentValue);
                }

                foreach (var kvp in outputDict)
                {
                    string key = kvp.Key;
                    var valuesList = kvp.Value;

                    Console.Write($"{key}=[{string.Join(", ", valuesList)}]");
                }

                Console.WriteLine();

                outputDict.Clear();
                input = Console.ReadLine();
            }
        }

        public static string ExtractKey(string currentKeyString)
        {
            currentKeyString = Regex.Replace(currentKeyString, @"%20|\+", " ");
            currentKeyString = Regex.Replace(currentKeyString, @"\s+", " ");
            currentKeyString = currentKeyString.Trim();

            return currentKeyString;
        }

        public static string ExtractValue(string currentValueString)
        {
            currentValueString = Regex.Replace(currentValueString, @"%20|\+", " ");
            currentValueString = Regex.Replace(currentValueString, @"\s+", " ");
            currentValueString = currentValueString.Trim();

            return currentValueString;
        }
    }
}