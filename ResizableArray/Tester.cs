using ResizableArrayPractice;
public class Tester
{
    // ----------------- Testing ----------------- 
    public static void Main()
    {
        ResizableArray<int> myArray = new ResizableArray<int>();

        // empty array
        myArray.Display();
        Console.WriteLine("\n-------------------------------");

        // deleting from empty array
        myArray.Delete();
        myArray.RemoveAt(0);
        myArray.Display();
        Console.WriteLine("\n-------------------------------");

        // 1 element
        myArray.Append(1);
        myArray.Display();
        Console.WriteLine("\n-------------------------------");

        // deleting from array with 1 element
        myArray.Delete();
        myArray.Display();
        Console.WriteLine("\n-------------------------------");

        // 2 elements
        myArray.Append(1);
        myArray.Append(2);
        myArray.Display();
        Console.WriteLine("\n-------------------------------");
        
        // 3 elements + expand size to 4
        myArray.Append(3);
        myArray.Display();
        Console.WriteLine("\n-------------------------------");
        
        // 5 elements + expand size to 8
        myArray.Append(4);
        myArray.Append(5);
        myArray.Display();
        Console.WriteLine("\n-------------------------------");

        // 8 elements
        myArray.Append(6);
        myArray.Append(7);
        myArray.Append(8);
        myArray.Display();
        Console.WriteLine("\n-------------------------------");

        // remove last element until first array shrink
        myArray.Delete();
        myArray.Delete();
        myArray.Delete();
        myArray.Delete();
        myArray.Display();
        Console.WriteLine("\n-------------------------------");

        // remove elements from middle of array
        myArray.Append(5);
        myArray.Append(6);
        myArray.Append(7);
        myArray.Append(8);
        myArray.RemoveAt(3);
        myArray.RemoveAt(3);
        myArray.Display();
        Console.WriteLine("\n-------------------------------");

        // remove elements from beginning of array
        myArray.RemoveAt(0);
        myArray.RemoveAt(0);
        myArray.Display();
        Console.WriteLine("\n-------------------------------");
    }
}