using System;
using System.Text.RegularExpressions;

namespace StringCalc
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            string[] stringValues;

            //regex to capture delimiter string using named match

            string delimiterPattern = @"^//(?<delimiter>[^0-9]+)\n"; 
            Match patternMatch = Regex.Match(input,delimiterPattern);

            if(patternMatch.Success)
            {
                //Custom Delimiters Specified

                var delimiters = patternMatch.Groups["delimiter"].Value.Split(',');
                input = Regex.Replace(input, delimiterPattern, "");
                stringValues = input.Split(delimiters, StringSplitOptions.None);
            } else {
                //Custom Delimiters not specified - using default

                stringValues = input.Split(',');
            }

            int sum = 0;

            foreach(string s in stringValues)
            {
                var value = 0;
                try {
                    value = Convert.ToInt32(s);
                } catch(Exception) { sum = 0; break;}

                if(value <= 1000)
                    sum += value;
            }

            return sum; 
        } 
    }  
}