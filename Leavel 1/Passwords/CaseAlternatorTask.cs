using System;
using System.Collections.Generic;

namespace Passwords
{
    public class CaseAlternatorTask
    {
        public static List<string> AlternateCharCases(string lowercaseWord)
        {
            var result = new List<string>();
            AlternateCharCases(lowercaseWord.ToCharArray(), 0, result);
            return result;
        }

        static void AlternateCharCases(char[] word, int charIndex, List<string> result)
        {
            if (word.Length == 0)
            {
                result.Add("");
                return;
            }
            if (charIndex == 0)
                result.Add(new string(word));
            if (charIndex < word.Length - 1)
                AlternateCharCases(word, charIndex + 1, result);
            if (char.IsLetter(word[charIndex]))
            {
                word[charIndex] = char.ToUpper(word[charIndex]);
                if (word[charIndex] != char.ToLower(word[charIndex]))
            	    result.Add(new string(word));
                else return;
                if (charIndex < word.Length - 1)
                    AlternateCharCases(word, charIndex + 1, result);
                word[charIndex] = char.ToLower(word[charIndex]);
            }
        }
    }
}