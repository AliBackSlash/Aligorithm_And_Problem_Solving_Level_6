// See https://aka.ms/new-console-template for more information

List<int> Sorted = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine($"Index of 7 in list of (Leaner_Search)[{string.Join(", ", Sorted)}] is " + Search.Leaner_search(Sorted, 7));

Console.WriteLine($"Index of 7 in list of (Binary_Search)[{string.Join(", ", Sorted)}] is " + Search.Binary_Search(Sorted, 7));


public static class Search
{
    public static int Leaner_search(List<int> ints, int target)
    {
        for (int i = 0; i < ints.Count; i++)
        {
            if (ints[i] == target)
                return i;
        }
        return -1;
    }
    public static int Binary_Search(List<int> ints, int target)
    {
        int Start = 0, middel = 0, End = ints.Count - 1;

        //1,2,3,4,5,6,7,8,9,10 target = 7

        while (Start <= End)
        {
            middel = Start + (End - Start) / 2;

            if (ints[middel] == target)
                return middel;
            else if (ints[middel] > target)
                End = middel - 1;
            else
                Start = middel + 1;


        }

        return -1;

    }
}

