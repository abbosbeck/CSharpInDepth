namespace Part2.GenericSinglyLinkedList
{
    class LinkedList<T>
    {
        private Node<T> head;
        public int Count { get; private set; }

        public LinkedList()
        {
            head = null;
            Count = 0;
        }

        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
            Count++;
        }

        public bool Remove(T data)
        {
            if (head == null)
                return false;

            if (EqualityComparer<T>.Default.Equals(head.Data, data))
            {
                head = head.Next;
                Count--;
                return true;
            }

            Node<T> current = head;
            while (current.Next != null && !EqualityComparer<T>.Default.Equals(current.Next.Data, data))
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
                Count--;
                return true;

                // A -> B -> C -> D
                // A.Next = C
                // C.Next = D
            }

            return false;
        }

        public void Display()
        {

            Node<T> current = head;
            while (current != null)
            {
                Console.WriteLine($"{current.Data} -> ");
                current = current.Next;
            }
        }

        public int GetCount()
        {
            return Count;
        }
    }
}
