using System.Net.Http.Headers;
using System.Text;

namespace AssignmentFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.


            //Console.WriteLine("Enter Your matrix  row n");
            //int.TryParse(Console.ReadLine(), out int nrow);
            //Console.WriteLine("Enter Your matrix  col n");
            //int.TryParse(Console.ReadLine(), out int nCol);
            //int[,] arr = new int[nrow, nCol];
            //for (int i = 0; i < nrow; i++)
            //{

            //    for (int j = 0; j < nCol; j++)
            //    {
            //        if (i == j)
            //            arr[i, j] = 1;
            //        else
            //            arr[i, j] = 0;


            //    }

            //}

            //Console.WriteLine(arr.Length);
            //// print element of array
            //for (int i = 0; i < nrow; i++)
            //{

            //    for (int j = 0; j < nCol; j++)
            //    {

            //        Console.Write(arr[i, j]);


            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Write a program in C# Sharp to find the sum of all elements of the array.

            //int[] numbers = new int[5] { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    sum+= numbers[i];

            //}
            //Console.WriteLine($"the sum is  = {sum}");

            #endregion

            #region  Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            int[] arr1 = { 100, 20, 50, 800 };
            int[] arr2 = { 8, 1, 10, 2 };
            int[] arr3 = new int[8];
            int i = 0;
            for (i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i]; 
            }



            for (int j = 0; j < arr2.Length; j++)
            {

                arr3[i] = arr2[j];
                i++;
            }

            Array.Sort(arr3);

            for (int j = 0; j < arr3.Length; j++)
            {

                Console.WriteLine(arr3[j]);
            }


            #endregion

            #region  Write a program in C# Sharp to count the frequency of each element of an array.

            //int[] number = new int[10] { 1, 2, 1, 3, 4, 3 ,5,10,5,1};

            //int count = 1;

            //int j = 0;

            //bool[] visited = new bool[10];
            //Console.WriteLine(visited[0]);
            //for (int i = 0; i<number.Length; i++)   //i==8
            //{

            //    if (visited[i]==true)
            //        continue;

            //    for ( j = i+1; j < number.Length; j++)   //j=9
            //    {

            //        if (number[i] == number[j])
            //        {

            //            count++;
            //            visited[j] = true;
            //        }


            //    }


            //        Console.Write(number[i]);
            //        Console.Write(" ");
            //        Console.WriteLine(count);
            //        count = 0;



            //}


            #endregion


            #region  Write a program in C# Sharp to find maximum and minimum element in an array

            //int[] arr = new int[5] { 10,100,50,1,9};

            //int max = arr[0];
            //int min = arr[0];

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }

            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}


            //Console.WriteLine($"Maximum element: {max}");
            //Console.WriteLine($"Minimum element: {min}");
            #endregion


            #region  Write a program in C# Sharp to find the second largest element in an array.


            //Console.Write("Enter the number of elements in the array: ");
            //int.TryParse(Console.ReadLine(), out int n);

            //if (n < 2)
            //{
            //    Console.WriteLine("Array must have at least two elements.");
            //    return;
            //}

            //int[] arr = new int[n];


            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element [{i + 1}]: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //// Initialize the largest and second largest
            //int max = int.MinValue;
            //int secondMax = int.MinValue;

            //// Find the largest and second largest elements
            //for (int i = 0; i < n; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        secondMax = max;
            //        max = arr[i];
            //    }
            //    else if (arr[i] > secondMax && arr[i] != max)
            //    {
            //        secondMax = arr[i];
            //    }
            //}

            //if (secondMax == int.MinValue)
            //{
            //    Console.WriteLine("There is no second largest element in the array.");
            //}
            //else
            //{
            //    Console.WriteLine($"The second largest element is: {secondMax}");
            //}


            #endregion


            #region Consider an Array of Integer values with size N, having values as ---




            //Console.Write("Enter the number of elements in the array: ");
            // int.TryParse(Console.ReadLine(),out int n);

            //int[] array = new int[n];


            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element [{i + 1}]: ");
            //   int.TryParse(Console.ReadLine(), out array[i]);
            //}

            //int maxDistance = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            int distance = j - i;
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine($"The longest distance between two equal cells is: {maxDistance}");


            #endregion

            #region Given a list of space separated words, reverse the order of the words.


            //Console.Write("Enter a space-separated list of words: ");
            //string input = Console.ReadLine();

            //string reversed = string.Join(" ", input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());

            //Console.WriteLine(reversed);
            #endregion


            #region Write a program to create two multidimensional arrays of same size. Accept values from the user and store them in first array. Now copy all the elements of the first array on second array and print second array.

            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());
            //Console.Write("Enter the number of columns: ");
            //int columns = int.Parse(Console.ReadLine());

            //int[,] firstArray = new int[rows, columns];
            //int[,] secondArray = new int[rows, columns];

            //Console.WriteLine("Enter the elements of the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"Element [{i + 1}, {j + 1}]: ");
            //        firstArray[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //// Copy elements from the first array to the second array
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        secondArray[i, j] = firstArray[i, j];
            //    }
            //}

            //// Print the second array
            //Console.WriteLine("The second array is:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(secondArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region Write a Program to Print One Dimensional Array in Reverse Order

            //Console.Write("Enter the number of elements in the array: ");
            // int.TryParse(Console.ReadLine(),out  int n);

            //int[] array = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element [{i + 1}]: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //// Print the array in reverse order
            //Console.WriteLine("The array in reverse order is:");
            //for (int i = n - 1; i >= 0; i--)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();

            #endregion




        }





    }
}
