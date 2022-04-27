namespace ResizableArrayPractice
{
    /// <summary>
    /// A an array which increases or decreases it's size dynamically to accomodate the number of elements in the array.
    /// </summary>
    public class ResizableArray<T>
    {
        private T[] resizableArray;
        private uint count;         // # of elements in array

        public ResizableArray()
        {
            count = 0;
            resizableArray = new T[1];
        }

        public T this[int index]
        {
            get => resizableArray[index];
        }

        public int Length()
        {
            return resizableArray.Length;
        }

        /// <summary>
        /// Adds an element to the end of the array.
        /// </summary>
        /// <param name="element">The value to be added.</param>
        public void Append(T element)
        {
            // double array size if needed
            if (count == resizableArray.Length)
            {
                AdjustArraySize(resizableArray.Length * 2);
            }

            // append element to array
            resizableArray[count] = element;
            count++;
        }

        /// <summary>
        /// Removes the last element in the array.
        /// </summary>
        public void Delete()
        {
            if (count > 0 && !resizableArray[count - 1].Equals(default(T)))
            {
                resizableArray[count - 1] = default(T);
                count--;

                // decrease array size if needed
                if (resizableArray.Length > 1 && count <= (resizableArray.Length / 2))
                {
                    AdjustArraySize(resizableArray.Length / 2);
                }
            }
        }

        /// <summary>
        /// Removes an element at the given index if it is not empty.
        /// </summary>
        /// <param name="index">The index in the array.</param>
        public void RemoveAt(int index)
        {
            if (count > 0 && !resizableArray[index].Equals(default(T)))
            {
                resizableArray[index] = default(T);
                count--;

                // shift all elements to the left to fill empty space
                for (int i = index; i < resizableArray.Length - 1; i++)
                {
                    resizableArray[i] = resizableArray[i + 1];
                }

                resizableArray[resizableArray.Length - 1] = default(T);

                // decrease array size if needed
                if (resizableArray.Length > 1 && count <= (resizableArray.Length / 2))
                {
                    AdjustArraySize(resizableArray.Length / 2);
                }
            }
        }

        /// <summary>
        /// Adjusts the arrays current size.
        /// </summary>
        private void AdjustArraySize(int newSize)
        {
            // expand/shrink array to accomodate # of elements in existing array
            T[] temp = new T[newSize];

            // copy over existing values
            for (int i = 0; i < count; i++)
            {
                temp[i] = resizableArray[i];
            }

            // update reference
            resizableArray = temp;
        }

        /// <summary>
        /// Prints out all elements in the array to console.
        /// </summary>
        public void Display()
        {
            Console.Write("Array: ");

            for (int i = 0; i < resizableArray.Length; i++)
            {
                Console.Write(resizableArray[i]);

                if (i + 1 < resizableArray.Length)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
