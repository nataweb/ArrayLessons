
//Task1.

Console.Write("\nType quantities of elements:\t");

int elementCount = int.Parse(Console.ReadLine());

int[] myArray = new int[elementCount];

for (int i = 0;i < myArray.Length; i++) 
{
    Console.Write($"\n Type element of array with index {i}:\t");
    myArray[i] = int.Parse(Console.ReadLine());

}
Console.WriteLine("\n Array to console output:");
for (int i = 0; i <myArray. Length; i++)
{
    Console.WriteLine(myArray[i]);
}

//Task2.Array in reverse order

int[] mineArray = {1,56,90,4};

Console.WriteLine("\n Array to console output:");

for (int i = mineArray.Length-1; i >= 0; i--)
{
  Console.WriteLine(mineArray[i]);
}

//Task3.Define even number in array and find the sum of even numbers

int[] array = {2,34,87,9,20,35,56,6,78 };

int result = 0;

for (int i = 0;i <array.Length; i++) 
{
    if (array[i]  %2 == 0)
    {
        result += array[i];
    }
}
Console.WriteLine(result);
