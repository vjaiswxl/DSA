using Microsoft.Identity.Client;

namespace ConsoleApp.CodeClass
{
    public class Recursion
    {
        public void PrintNums(int iterator, int n)
        {
            if (iterator < 1)
            {
                return;
            }
            Console.WriteLine(iterator);
            PrintNums(iterator - 1, n);
        }

        public int[] ReverseArray()
        {
            int[] numbers = { 50, 20, 40, 10, 30 }; //[30,10,40,20,50]

            int size = numbers.Length;

            int[] newArr = new int[size];

            int iterator = 0;

            for (int i = size - 1; i >= 0; i--)
            {
                newArr[iterator] = numbers[i];
                iterator++;
            }

            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }

            return newArr;
        }

        public void ReverseArray2P()
        {
            int[] numbers = { 50, 20, 40, 10, 30 }; //[30,10,40,20,50]

            int size = numbers.Length;

            int low = 0;
            int high = size - 1;

            while (low != high && low < high)
            {
                int temp = numbers[low];
                numbers[low] = numbers[high];
                numbers[high] = temp;

                low++; high--;
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }

        public bool IsPalindrome(string s)
        {
            bool result = false;

            int size = s.Length;

            int low = 0;
            int high = size - 1;

            while (low != high && low < high)
            {
               if (s[low] == s[high])
                {
                    result = true;
                }
                low ++;
                high --;
            }

            if (result == true)
            {
                Console.WriteLine($"String {s} is Palindrome");
            } else
            {
                Console.WriteLine($"String {s} is not a palindrome");
            }
            
            return result;
        }


        //Fibonacci: $F_n = F_{n-1} + F_{n-2}$
        public int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
           
           int last = Fibonacci(n - 1);
           int slast = Fibonacci(n - 2);
           
           Console.WriteLine(last+slast);

           return last+slast;
        }
    }
}