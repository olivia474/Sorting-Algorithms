namespace Sorting_Algorithms;
class Program
{
    public static void Main()
    {
        int[] array = { 75, 25, 1, 46, 11 };

        Console.Write("Original array: ");
        SelectionSort.PrintArray(array);

        SelectionSort.Sort(array);

        Console.Write("Sorted array: ");
        SelectionSort.PrintArray(array);
    }

}
