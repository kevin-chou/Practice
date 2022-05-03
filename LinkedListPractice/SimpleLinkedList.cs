namespace LinkedListPractice
{
    /// <summary>
    /// Practice implementation of a doubly linked list.
    /// Outer class serves as a wrapper for the internal linked list node.
    /// </summary>
    public class SimpleLinkedList<T>
    {
        /// <summary>
        /// Class representing a single node in a linked list.
        /// </summary>
        public class Node
        {
            private Node? next;
            private Node? previous;
            private readonly T data;

            public T Data
            {
                get { return data; }
            }

            public Node? Next
            {
                get { return next; }
                set { next = value; }
            }

            public Node? Previous
            {
                get { return previous; }
                set { previous = value; }
            }

            public Node(T data)
            {
                next = null;
                previous = null;
                this.data = data;
            }
        }

        private Node? head;

        public SimpleLinkedList()
        {
            head = null;
        }

        /// <summary>
        /// Adds a new element to the end of the linked list.
        /// </summary>
        /// <param name="data">The data to be added to linked list.</param>
        public void Append(T data)
        {
            Node? curr = head;
            Node node = new Node(data);

            // linked list was empty
            if (head == null)
            {
                head = node;
                return;
            }

            // not empty, so traverse linked list and find the last node or "tail"
            while (curr?.Next != null)
            {
                curr = curr.Next;
            }

            // attach or "link" the new node to the end of the list
            curr.Next = node;
            node.Previous = curr;
        }

        /// <summary>
        /// Adds a new element to the beginning of the linked list.
        /// </summary>
        /// <param name="data">The data to be added to linked list.</param>
        public void Prepend(T data)
        {
            // creating a node for the new head
            Node node = new Node(data);
            node.Next = head;

            // update links from original (if it exists)
            if (head != null)
            {
                head.Previous = node;
            }

            // assign the new node as the new head
            head = node;
        }

        /// <summary>
        /// Deletes the first element that contains the data.
        /// </summary>
        /// <param name="data">The data to be deleted.</param>
        /// <returns>True if operation successful and false otherwise.</returns>
        public bool Delete(T data)
        {
            // list is empty, no need to search
            if (head == null)
            {
                return false;
            }

            // data is at first element, so we can easily delete it
            // by moving head to next node
            if (head.Data.Equals(data))
            {
                head = head.Next;

                if (head != null && head.Next != null)
                {
                    head.Previous = null;
                }
                
                return true;
            }

            // otherwise traverse list while searching for the data
            Node? curr = head;

            while(curr != null)
            { 
                if (curr.Data != null && curr.Data.Equals(data))
                {
                    // found match, delete it from list by updating links
                    curr.Previous.Next = curr.Next;

                    if (curr.Next != null)
                    {
                        curr.Next.Previous = curr.Previous;
                    }

                    return true;
                }

                curr = curr.Next;
            }

            return false;
        }

        /// <summary>
        /// Prints out a visual representation of the linked list to console.
        /// </summary>
        public void Display()
        {
            Node? curr = head;

            while (curr != null)
            {
                Console.Write("[ " + curr.Data.ToString() + " ]");

                if (curr.Next != null)
                {
                    Console.Write(" - ");
                }

                curr = curr.Next;
            }

            Console.WriteLine();
        }
    }
}