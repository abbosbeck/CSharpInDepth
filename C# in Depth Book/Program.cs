using Part2;
using System.Runtime.InteropServices.Marshalling;
using static Part2.UsingDelegates;


/* Types  var anonymousTypesAndTuples = new AnonymousTypesAndAnonymousTypesAndTuples();

anonymousTypesAndTuples.TupleTypes();

anonymousTypesAndTuples.AnonymousType();

await anonymousTypesAndTuples.GetWeatherAsync();
anonymousTypesAndTuples.GetEmailStatusAsync();

await Task.Delay(1001);

Console.WriteLine("Hello World! This is from Program.cs"); */

/*foreach(string name in Generics<int>.GenerateNames())
{
    Console.WriteLine(name);
}*/

/*Generics<string>.Increment();
Generics<string>.Increment();
Generics<string>.Display();

Generics<int>.Display();
Generics<int>.Increment();
Generics<int>.Display();

Generics<string>.Increment();
Generics<string>.Increment();
Generics<string>.Display();*/

/*Part2.GenericSinglyLinkedList.LinkedList<string> linkedListNames = new Part2.GenericSinglyLinkedList.LinkedList<string>();

linkedListNames.Add("Jon");
linkedListNames.Add("Tom");
linkedListNames.Add("Jerry");
linkedListNames.Add("Mickey");
linkedListNames.Add("Minnie");
linkedListNames.Add("NKLKUK");
linkedListNames.Add("NUIKHKUJ");

linkedListNames.Remove("Mickey");

Part2.GenericSinglyLinkedList.LinkedList<int> linkedListAges = new Part2.GenericSinglyLinkedList.LinkedList<int>();

linkedListAges.Add(15);
linkedListAges.Add(20);
linkedListAges.Add(25);
linkedListAges.Add(30);
linkedListAges.Display();*/

/*NullableGeneric<int> nullableGeneric = new NullableGeneric<int>();

Console.WriteLine(nullableGeneric.HasValue);*/

/*string name = "Jon";
string name2 = name;

name2 = "Tom";

Console.WriteLine(name);*/

/*NullableValueTypes.PrinValueAsInt(5);
NullableValueTypes.PrinValueAsInt("Hii");*/

/*int? a = null;
int b = 10;
int c = a ?? b;

Console.WriteLine(c);*/

/*var usingDelegate = new UsingDelegates();

Delegate1 delegate1 = new Delegate1(usingDelegate.Multiple);
delegate1 += usingDelegate.Multiple;
delegate1 += usingDelegate.Minus;

delegate1 += delegate (int x, int y)
{
    return x + y;
};

delegate1 += (x, y) => x+y-(x * y);

delegate1(10, 5);

delegate1.Invoke(50, 100);*/

/*int counter = 0;  // This variable is in the outer scope

// Define an anonymous method that captures 'counter'
Action increment = delegate () {
    counter++;  // 'counter' is captured from the surrounding scope
    Console.WriteLine("Counter is now: " + counter);
};

// Calling the anonymous method multiple times
increment(); // Output: Counter is now: 1
increment(); // Output: Counter is now: 2

// The change is visible in the outer scope
Console.WriteLine("Final counter: " + counter); // Output: Final counter: 2*/

//Collections.CollocationIenumrable();

// Using an array
// IEnumerable can work any type of collection - this abstraction is a big advantage
//int[] numbersArray = { 1, 2, 3, 4, 5 };
//Console.WriteLine("Array elements:");
//Collections.PrintElements(numbersArray);

//// Using a List<T>
//List<string> namesList = new List<string> { "Alice", "Bob", "Charlie" };
//Console.WriteLine("\nList elements:");
//Collections.PrintElements(namesList);

MyCustomCollection myCustomCollection = new MyCustomCollection();
myCustomCollection.Add(1);
myCustomCollection.Add(2);
myCustomCollection.Add(3);
myCustomCollection.Add(4);
myCustomCollection.Add(5);

Console.WriteLine("Custom collections elements:");
foreach(int item in myCustomCollection)
{
    Console.WriteLine(item);
}
