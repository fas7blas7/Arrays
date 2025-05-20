1️⃣ DayOfWeek 📆  
Namespace: _7_DayOfWeek  
📌 Description:  
Reads an integer from 1 to 7 and prints the corresponding day of the week. If the number is out of range, it outputs "Invalid day!".

📝 Code:
```csharp
namespace _7_DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 7)
            {
                Console.WriteLine(days[number - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}

2️⃣ SumAnArray ➕  
Namespace: _8_SumAnArray  
📌 Description:  
Reads a sequence of integers from a single line, sums them, and prints the result.

📝 Code:
```csharp
namespace _8_SumAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine()
                                    .Split(" ")
                                    .Select(int.Parse)
                                    .ToArray();        

            int sum = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                int currentNumber = numbersArray[i];
                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
```
3️⃣ ReverseAnArray 🔄
Namespace: _9_ReverseAnArray
📌 Description:
Reads a specified number of integers, stores them in an array, reverses it, and prints the reversed array.

📝 Code:
```
namespace _9_ReverseAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}

```
4️⃣ EvenVsOdd ➖➕
Namespace: _10_EvenVsOdd
📌 Description:
Reads a sequence of integers, calculates the sum of even and odd numbers separately, and prints the difference (even sum minus odd sum).

📝 Code:
```
namespace _10_EvenVsOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(" ")
                                   .Select(int.Parse)
                                   .ToArray();

            int evenSum = 0;
            int oddSum = 0;

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }

            Console.WriteLine(evenSum - oddSum);
        }
    }
}
```
✅ Modified README.md content:
md
Copy
Edit
5️⃣ ZigZagArrays 🔀  
Namespace: _05.ZigZagArrays  
📌 Description:  
Reads a sequence of pairs of integers and fills two arrays in a zig-zag pattern: first array gets the first number on even rows and the second on odd rows; vice versa for the second array.

📝 Code:
```csharp
namespace _05.ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currentNumberPair = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int firstNumber = currentNumberPair[0];
                int secondNumber = currentNumberPair[1];
                if (i % 2 == 0)
                {
                    firstArray[i] = firstNumber;
                    secondArray[i] = secondNumber;
                }
                else
                {
                    firstArray[i] = secondNumber;
                    secondArray[i] = firstNumber;
                }
            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}

```
📅 Commit Progress Update:

📅 Current Progress: 419 commits
📊 Progress Bar:
████████████████████████████████████▌83.8% (419/500)

📌 Milestones:
✅ 100 commits
✅ 200 commits
✅ 300 commits
✅ 400 commits
🔲 500 commits (🎉)

🎯 Commit Progress Tracker
🚀 Goal: 500 commits in 2025
