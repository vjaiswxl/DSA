using System;
using System.Collections.Generic;

namespace ConsoleApp.CodeClass {
    public class isAnagramProblem {

        public bool isAnagram (string s, string t) {
            if (s.Length != t.Length) {
                return false;
            }

            char[] sArray = s.ToCharArray ();
            char [] tArr = t.ToCharArray ();

            Array.Sort (sArray);
            Array.Sort (tArr);

            if (sArray.SequenceEqual (tArr)) {
                Console.WriteLine ("IsAnagram");
                return true;
            }
             Console.WriteLine ("NotAnagram");
            return false;
        }

    }
}