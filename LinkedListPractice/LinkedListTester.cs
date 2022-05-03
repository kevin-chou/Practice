namespace LinkedListPractice
{
    public class LinkedListTester
    {
        public static void Main()
        {
            var list = new SimpleLinkedList<string>();

            // empty list
            list.Display();

            // prepend element to empty list
            list.Prepend("Mug");
            list.Display();

            // delete head in list with only one element
            list.Delete("Mug");

            // list with one element
            list.Append("Charlie");
            list.Display();

            // list with two elements
            list.Append("Watchdog");
            list.Display();

            // list with 4 elements
            list.Append("Birthday");
            list.Append("Salamander");
            list.Display();

            // delete non existent element
            list.Delete("Holiday");
            list.Display();

            // delete element in the middle ("Watchdog")
            list.Delete("Watchdog");
            list.Display();

            // delete last element
            list.Delete("Salamander");
            list.Display();

            // append elements after deleting last element
            list.Append("Crazy");
            list.Append("Keyboard");
            list.Append("Johnny");
            list.Display();

            // delete multiple head elements
            list.Delete("Charlie");
            list.Delete("Birthday");
            list.Display();

            // delete until empty
            list.Delete("Crazy");
            list.Delete("Keyboard");
            list.Delete("Johnny");
            list.Display();

            // add new element to new empty list
            list.Append("Linked");
            list.Display();
        }
    }
}
