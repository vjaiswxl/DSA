using System;
using System.Collections.Generic;

namespace ConsoleApp.CodeClass
{
    public class EncodeDecode
    {
        public string Encode(IList<string> strs)
        {
            string? encodedString = null;
            for (int i = 0; i < strs.Count; i++)
            {
                if (i == 0)
                {
                    encodedString += strs[i];
                }
                else
                {
                    encodedString = encodedString + "#5" + strs[i];
                }
            }
            if (encodedString != null)
            {
                return encodedString;
            } else {
                return " ";
            }

        }

        public List<string> Decode(string s)
        {
            List<string> decodedValue = new List<string>();

            if (s == null)
            {
                decodedValue = new List<string>();
            }
            else
            {
                string[] spiltValues = s.Split("#5");

                foreach (string spiltValue in spiltValues)
                {
                    decodedValue.Add(spiltValue);
                }
            }

            return decodedValue;

        }
    }
}