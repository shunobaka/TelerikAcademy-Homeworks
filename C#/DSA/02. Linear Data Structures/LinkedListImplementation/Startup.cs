// 11. Implement the data structure linked list.

// Define a class ListItem<T> that has two fields: value (of type T) and NextItem (of type ListItem<T>).
// Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).

namespace LinkedListImplementation
{
    public class Startup
    {
        public static void Main()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            ListItem<int> itemOne = new ListItem<int>() { Value = 10 };
            linkedList.FirstElement = itemOne;

            ListItem<int> itemTwo = new ListItem<int>() { Value = 20 };
            itemOne.NextItem = itemTwo;

            ListItem<int> itemThree = new ListItem<int>() { Value = 55 };
            itemTwo.NextItem = itemThree;
        }
    }
}
