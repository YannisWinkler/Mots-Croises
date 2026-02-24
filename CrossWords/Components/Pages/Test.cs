using System;

namespace CrossWords.Components.Test;

public class Test
{
    public void TestPath()
    {
        Console.WriteLine("test");
    }
    public void PrintIntersection(string[] id1, string[] id2)
    {
        IEnumerable<string> both = id1.Intersect(id2);
        foreach (string id in both)
            Console.WriteLine(id);
    }
    public void GetIntersection()
    {
        // string[] word = { "W", "o", "r", "d" };
        // string[] cross = { "C", "r", "o", "s", "s" };
        string[] word = { "Word" };
        string[] cross = { "Cross" };

        Console.WriteLine(word.Intersect(cross));
        // PrintIntersection(word, cross);
        TestPath();
    }

}