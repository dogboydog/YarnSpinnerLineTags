
using System;
using System.IO;
public class Program
{
    public static void Main(string[] args)
    {
        var original = File.ReadAllText("../../../Hello.yarn");
        Console.WriteLine($"Before:\n{original}");
        var tagsAdded = Yarn.Compiler.Utility.AddTagsToLines(original);
        Console.WriteLine($"\nAfter:\n{tagsAdded}");
    }
}
