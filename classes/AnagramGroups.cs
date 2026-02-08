using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace ConsoleApp.CodeClass
{
    public class AnagramGroupProblem
    {
        public List<List<string>> GroupAnagrams(string[] strs)
        {
            //Mine
            // Dictionary<string, string> AnagramDict = new Dictionary<string, string>();
            // List<List<string>> result = new List<List<string>>();
            // for (int i = 0; i < strs.Length; i++) {
            //     char[] sortStrs = strs[i].ToCharArray();
            //     Array.Sort(sortStrs);
            //     string finalSortedStng = new string(sortStrs);
            // if (!AnagramDict.ContainsKey(strs[i]))
            // {
            //     AnagramDict.Add(strs[i], finalSortedStng);
            // } else {
            //     List<string> newAnagram = new List<string>();
            //     newAnagram.Add(strs[i]);
            //     result.Add(newAnagram);
            // }

            // }
            //  var matchingKeys = AnagramDict.GroupBy(pair => pair.Value).Select(group => group.Select(pair => pair.Key).ToList()).ToArray();

            //  foreach (List<string> innerArray in matchingKeys ) {
            //     result.Add(innerArray);
            //  };
            //     return result;

            //ChatGpt Approach
            Dictionary<string, List<string>> AnagramDict = new Dictionary<string, List<string>>();
            List<List<string>> result = new List<List<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                char[] sortStrs = strs[i].ToCharArray();
                Array.Sort(sortStrs);
                string finalSortedStng = new string(sortStrs);

                if (AnagramDict.ContainsKey(finalSortedStng))
                {
                    AnagramDict[finalSortedStng].Add(strs[i]);
                }
                else
                {
                    AnagramDict[finalSortedStng] = new List<string> { strs[i] };
                }
            }

            foreach (var anagramGroup in AnagramDict.Values)
            {
                result.Add(anagramGroup);
            }

            return result;
        }
    }
}