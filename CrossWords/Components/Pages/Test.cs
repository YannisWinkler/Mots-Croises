using System;

namespace CrossWords.Components.Test;

public class Test
{
    public void TestPath()
    {
        Console.WriteLine("test");
    }
    public void JointLetter(string word1, string word2)
    {
        char[] id1 = word1.ToCharArray();// Convert the first string to a character array
        char[] id2 = word2.ToCharArray();
        var both = id1.Intersect(id2);

        Console.WriteLine(string.Join(", ", both));
    }

}