void printArray<T>(T[] array)
{
    foreach (var item in array) Console.WriteLine(item);
}

int[] uppgift1(int num1, int num2)
{
    int range = num2 - num1;
    int[] res = new int[(range + ( range % 2 == 0 ? 0 : 1 )) / 2];

    if (num1 % 2 == 0) num1 += 1;

    int j = 0;
    for (int i = num1; i < num2; i += 2)
    {
        res[j] = i;
        j += 1;
    }

    return res;
}

var nummer = uppgift1(1, 9);
printArray(nummer);

string uppgift2(string[] arr)
{
    Console.Write($"ange indexpos (0-{arr.Length - 1}):");
    bool workyworky = int.TryParse(Console.ReadLine(), out int indexPos);
    if (indexPos < 0 || indexPos > arr.Length - 1) return $"indexPos outside of range 0-{arr.Length - 1}";
    if(!workyworky) return "could not parse indexPos as int";
    return arr[indexPos];
}

string[] u2Arr = { "asdasdsa", "asdasdasdads", "bimbim bam", "BIMBIBM", "AAAAAAAAAAAAAAAAAAA" };
printArray(u2Arr);
Console.WriteLine(uppgift2(u2Arr));
static int[] RandomIntArray(int length, int lowestValue, int highestValue)
{
    if (lowestValue > highestValue)
    {
        int temp = lowestValue;
        lowestValue = highestValue;
        highestValue = temp;
    }
    Random r = new Random();
    int[] arr = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = r.Next(lowestValue, highestValue);
    }
    return arr;
}


void sortArray(int[] a)
{
    bool sorted = false;
    while(!sorted)
    {
        bool hasSwapped = false;
        for(int i = 1; i < a.Length; i++)
        {
            if (a[i - 1] > a[i])
            {
                int temp = a[i];
                a[i] = a[i - 1];
                a[i - 1] = temp;

                hasSwapped = true;
            }
        }
        sorted = !hasSwapped;
    }
}

int[] arr = RandomIntArray(10, 0, 100);
printArray(arr);
Console.WriteLine("######################");

sortArray(arr);
printArray(arr);