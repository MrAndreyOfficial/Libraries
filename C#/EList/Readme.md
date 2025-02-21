This library has extension methods for ```IList<T>``` in class ```ListExteniosns``` in the ```EList``` namespace

## Methods
```
    RemoveDuplicate<T>()
    RemoveUntil<T>(T item)
    Push<T>(T item)
    Pop<T>()
```

### Example
```
using EList;

// Remove all duplicate

var numbers = new List<int> { 10, 20, 30, 75, 75, 85, 85 }.RemoveDuplicate();

foreach (var element in numbers)
    Console.Write($"{element}\t"); // 10 20 30 75 85

Console.WriteLine();

// List as Stack

numbers.Push(100);
numbers.Push(125);

foreach (var element in numbers)
    Console.Write($"{element}\t"); // 10 20 30 75 85 125

numbers.Pop();

Console.WriteLine();

foreach (var element in numbers)
    Console.Write($"{element}\t"); // 10 20 30 75 85 100

// Remove all elements until 75 is found

numbers.RemoveUntil(75);

Console.WriteLine();

foreach (var element in numbers)
    Console.Write($"{element}\t"); // 75 85 100
```
