using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace ConsoleApp.CodeClass {
    public class SelectionSort {
        public int[] SelectSort (int[] arr, int n)
        {
            for(int i = 0; i < n - 1; i++) {
                int minimum = i;
                for (int j = i + 1 ; j < n; j++){
                    if (arr[j] < arr[minimum]) {
                        minimum = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minimum];
                arr[minimum] = temp;
            }
            return arr;
        }
    }
}