

//Find minValue in Array

int[] myArray = { 2, 6, 9, 10, 12, 889, 76, 56, 45, 80 };

int minValue = myArray[0];

for (int i = 1; i < myArray.Length; i++)
{
    if (myArray[i] < minValue)
    {
        minValue = myArray[i];
    }
}
Console.WriteLine(minValue);

//Find maxValue in Array

int maxValue = myArray[0];

for (int i = 1; i < myArray.Length; i++)
{
    if (myArray[i] > maxValue) 
    {
       maxValue = myArray[i];
    }
}
Console.WriteLine(maxValue);

//27.Lesson
int[] mineArray = { 111, 10, 4, 99,111, 47, 69, 77,99, 5, 25, 5, 89 };
int[] result = mineArray.Distinct().ToArray();
Console.WriteLine(result);

//Console.WriteLine(mineArray.Max());
//Console.WriteLine(mineArray.Min());
//Console.WriteLine(mineArray.Sum());
//Console.WriteLine(mineArray.Where(i => i % 2 == 0).Sum());
////Sum of even numbers
//Console.WriteLine(mineArray.Where(i => i % 2 != 0).Min());

//Continue
int[] firstArray = { 111, 10, 4, 99, 111, 47, 69, 77, 99, 5, 25, 5, 89 };
Array.Sort(firstArray);
Array.Reverse(firstArray);  
int resultive = Array.Find(firstArray,i => i < 70);
Console.WriteLine( firstArray );
Console.WriteLine( resultive );