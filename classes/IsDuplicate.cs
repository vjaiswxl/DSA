using System;
using System.Collections.Generic;

namespace ConsoleApp.CodeClass {

    public class IsDuplicateProblem {
        
        public bool IsDuplicate (int [] num) {

            Array.Sort (num);

            for (int i = 1; i < num.Length; i++) {
                if (num[i] == num[i-1]) {
                    Console.WriteLine("Duplicate Found at:" + num [i]);
                    return true;
                } 
            }
            Console.WriteLine("No Duplicates in the array");
            return false;
        }
    }
}