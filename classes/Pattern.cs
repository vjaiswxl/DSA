using GenericFunctions;


namespace ConsoleApp.CodeClass
{
    public class Pattern
    {
        GenericClass<string> gc = new GenericClass<string>();
        public void Pattern_One(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    gc.Print("*");
                }
                Console.WriteLine();
            }
        }

        public void Pattern_Two(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < n - (n - 1 - i); j++) //this n - (n-1-i) is just i
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public void Pattern_Three(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void Pattern_Four(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n - i- 1); j++)
                {
                    Console.Write(" ");
                }
                 for (int j = 0; j < (2*i) - 1; j++)
                {
                    Console.Write("*");
                }
                 for (int j = 0; j < (n - i -1); j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
