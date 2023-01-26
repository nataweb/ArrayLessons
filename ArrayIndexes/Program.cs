//How to get last element of array

int[] myArray = { 2, 8, 6, 20, 56, 77, 98, 100 };
//Console.WriteLine(myArray[myArray.Length -1]);
//Console.WriteLine(myArray[^1]);
//int[] myArray1 = myArray[..5];

int[] myArray2 = myArray[4..];

//Index

int[] newArray = { 2, 8, 6, 20, 56, 77, 98, 100 };
Index myIndex = ^3;
Console.WriteLine(newArray[myIndex]);
Console.WriteLine($"value: {myIndex.Value} isFromEnd: {myIndex.IsFromEnd}");

string word = "Hello World!=)";
Console.WriteLine(word[^2..]);

