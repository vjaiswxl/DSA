using System.Globalization;

namespace ConsoleApp.CodeClass
{
    public class SortingAlgos
    {
        public void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i <= n- 2; i++)
            {
                int min = i;
                for (int j = i; j <= n-1 ; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        
                        min = j;
                    //     int temp = arr[j];
                    //     arr[j] = arr[min];
                    //     arr[min] = temp;
                    }
                }
                (arr[i],arr[min]) = (arr[min], arr[i]);
            }

            foreach (var el in arr)
            {
                Console.WriteLine(el);
            }
        }

        public void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for(int i = n - 1; i >= 1; i--)
            {
                for (int j = 0; j <= i-1; j++) //We are looping till (n-1)-1 to prevent index out of bound error when comparing the next element
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j],arr[j+1]) = (arr[j+1],arr[j]);
                    }
                }
            }

            foreach (var el in arr)
            {
                Console.WriteLine(el);
            }
        }

        public void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for(int i = 0; i < n; i++)
            {
                int j = i;
                while (j > 0 && arr[j-1] > arr[j])
                {
                    (arr[j-1],arr[j]) = (arr[j],arr[j-1]);

                     j--;
                }
               
            }

            foreach (var el in arr)
            {
                Console.WriteLine(el);
            }
        }
    }
}