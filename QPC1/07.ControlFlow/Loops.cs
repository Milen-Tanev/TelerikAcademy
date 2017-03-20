private const int SearchedVlaue = 666;

Array array = new Array[100];
int arrayLength = array.Length();

int index;
for (index = 0; index< arrayLength; index++)
{
    Console.WriteLine(array[index]);

    bool isEveryTenthIndex = (index % 10 == 0);
    if (isEveryTenthIndex && array[index] == expectedValue)
    {
        index = SearchedVlaue;
        Console.WriteLine("Value Found");
    }
}

// More code here
