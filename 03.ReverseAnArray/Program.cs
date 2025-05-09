
int n = int.Parse(Console.ReadLine());


int[] numbers = new int[n];

for (int i = 0; i < n; i++)
{
    int currNum = int.Parse(Console.ReadLine());

    numbers[i] = currNum;
}

int[] reversedArray = new int[n];

for (int i = numbers.Length - 1; i >= 0; i--)
{
    reversedArray[numbers.Length - i - 1] = numbers[i];
}

Console.WriteLine(string.Join(" ", reversedArray));


//numbers = numbers.Reverse().ToArray();
//Console.WriteLine(string.Join(" ", numbers));

