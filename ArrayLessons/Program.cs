//26.Lesson
int[] array = new[] { 55, 77, 88, 73, 40 };
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

//24.Lesson
int[] myArray;
myArray = new int[15];
//myArray[1] = 3;
//myArray[0] = 10;
//int a = myArray[0];
Console.WriteLine(myArray.Length);

//25.Lesson

int[] mineArray = new int[5] {5,6,9,8,3 };

Console.WriteLine(mineArray[4]);

//int[] mineArray = { 5, 7, 8, 3, 4 }; //Or Syntax

int[] mineArray1 = Enumerable.Repeat(7, 12).ToArray();
Console.WriteLine(mineArray1[0]);

int[] mineArray2 = Enumerable.Range(5, 10).ToArray();

Console.WriteLine(mineArray2[4]);

Console.ReadLine();




