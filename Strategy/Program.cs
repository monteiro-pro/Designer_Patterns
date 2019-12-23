using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList studentRecords = new SortedList();
            studentRecords.Add("Rodrigo");
            studentRecords.Add("Maria");
            studentRecords.Add("João");
            studentRecords.Add("Carlos");
            studentRecords.Add("Pedro");

            studentRecords.SetSortStrategy(new QuickSorte());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            Console.ReadKey();
        }
    }
}