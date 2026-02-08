

namespace ConsoleApp.CodeClass
{
    public class Maths
    {
        public int CountDigits_Optimal(double n)
        {

            double num = Math.Log(n, 10) + 1;

            //Math.Floor(num);

            Console.WriteLine((int)(num));

            return (int)(num);
        }

        public int CountDigits_Brute(int n)
        {
            int count = 0;

            while (n > 0)
            {
                int nn = n % 10;

                count++;

                n = n / 10;
            }
            Console.WriteLine(count);
            return count;
        }

        public int ReverseNum(int n)
        {
            int original = n;
            int reversed = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;

                reversed = reversed * 10 + lastDigit;

                n = n / 10;
            }
            Console.WriteLine(reversed);

            if (original == reversed)
            {
                Console.WriteLine("It is a Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }

            return reversed;
        }

        public int GCD(int n1, int n2)
        {
            int n = Math.Min(n1, n2);

            int gcd = 1;

            for (int i = 1; i <= n; i++)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    gcd = i;
                }
            }
            Console.WriteLine(gcd);
            return gcd;
        }

        //Brute Force
        public List<int> GetAllDivisors(int n)
        {
            List<int> Div = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Div.Add(i);
                }
            }
            foreach (int item in Div)
            {
                Console.WriteLine(item);
            }
            return Div;
        }


        // Sqrt Method:

        // 1*36 n/1
        // 2*18 n/2
        // 3*12 n/3
        // 4*9  n/4
        // 6*6  n/6

        public bool CheckForPrime(int n)
        {
            List<int> factors = new List<int>();
            int factCount = 0;
            bool isPrime = false;
            for (int i = 1; i * i <= n; i++) //i*i<=n is same as Math.Sqrt(n) 6*6 <= 36, 7*7 != 36
            {
                if (n % i == 0)
                {
                    factors.Add(i);
                    factCount++;
                    if ((n / i) != i) //Check the sqrt method 
                    {
                        factors.Add(n / i);
                        factCount++;
                    }
                }

            }

            factors.Sort();

            foreach (var factor in factors)
            {
                Console.WriteLine(factor);  //Print all the factors as well
            }

            if (factCount == 2)
            {
                isPrime = true;
            }

            Console.WriteLine($"isPrime: {isPrime}");
            return isPrime;
        }

        //Euclidean Algorithm:

        /* 
        GCD(a,b) = GCD(a-b,a) where a>b
        OR
        GCD(a,b) = GCD(a%b,a) where a>b //Better Approach
        */

        public int Euclidean(int a, int b)
        {
            while (a > 0 && b > 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }

            if (a == 0)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
    }
}