using HashTablePractice;
public class HashTableTester
{
    public static void Main()
    {
        HashLP<string, string> myHashTable = new HashLP<string, string>(3);
        Console.WriteLine(myHashTable.Delete("hello"));

        Console.WriteLine(myHashTable.Insert("hello", "world"));
        Console.WriteLine(myHashTable.Insert("abcd", "efgh"));
        Console.WriteLine(myHashTable.Insert("water", "rock"));
        Console.WriteLine(myHashTable.Insert("special", "continent"));
        Console.WriteLine(myHashTable.Insert("dark", "light"));
        Console.WriteLine(myHashTable.Insert("frequency", "human"));

        Console.WriteLine(myHashTable.Search("hello"));
        Console.WriteLine(myHashTable.Search("frequency"));
        Console.WriteLine(myHashTable.Search("unknown key"));
        Console.WriteLine(myHashTable.Search("water"));

        Console.WriteLine(myHashTable.Delete("hello"));
        Console.WriteLine(myHashTable.Delete("water"));
        Console.WriteLine(myHashTable.Delete("hello"));
        Console.WriteLine(myHashTable.Delete("water"));

        Console.WriteLine(myHashTable.Search("hello"));
        Console.WriteLine(myHashTable.Search("abcd"));
        Console.WriteLine(myHashTable.Search("water"));
    }
}
