using System;

namespace CSBasicsExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Question 1 /// 
            //int age;
            //string nationality;
            //bool isParsed;
            //do
            //{
            //    Console.Write("Enter age: ");
            //    isParsed = int.TryParse(Console.ReadLine(), out age);
            //}
            //while (!isParsed);
            //Console.Write("Enter nationality: ");
            //nationality = Console.ReadLine()!;
            //Console.WriteLine(CheckEligible(age, nationality));

            /// Question 2 ///
            //float num1, num2;
            //char op;
            //Console.Write("Enter First number: ");
            //float.TryParse(Console.ReadLine(), out num1);
            //do
            //{
            //    Console.Write("Enter second number: ");
            //    float.TryParse(Console.ReadLine(), out num2);
            //    Console.Write("Enter operator (+, -, *, /): ");
            //    op = char.Parse(Console.ReadLine());
            //} while (CheckZero(num2) && op == '/');
            //Calculator(num1, num2, op);


            /// Question 3 ///
            //int num;
            //Console.WriteLine("Enter N: ");
            //int.TryParse(Console.ReadLine(), out num);
            //PrintMultiplicationTable(num);


            /// Question 4 ///
            //Console.Write("Enter size of array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] numbers = new int[size];
            //FillArray(numbers);
            //PrintPrimeNumbers(numbers);

            /// Question 5 ///
            //Console.WriteLine("Getting Maximum and Index");
            //int size = 10;
            //int[] arr = new int[size];
            //int max;
            //int maxIndex;
            //FillArray(arr);
            //FindMaxandIndex(arr, out max, out maxIndex);
            //Console.WriteLine($"Maximum is : {max} at index {maxIndex}");

            /// Question 6 ///
            Console.Write("Enter your word : ");
            string word = Console.ReadLine();
            Console.WriteLine($"Word is {isPalindrome(word).ToString()}");


            /// Question 7 ///
            //int? num1, num2;
            //bool isParsed;
            //int value1,value2;
            //Console.Write("Enter First number: ");
            //isParsed = int.TryParse(Console.ReadLine(), out value1);
            //num1 = GetNullableInt(value1, isParsed);
            //do
            //{
            //    Console.Write("Enter second number: ");
            //    isParsed  = int.TryParse(Console.ReadLine(), out value2);
            //    num2 = GetNullableInt(value2, isParsed);
            //} while (isParsed && CheckZero(value2));
            //int? result = DivideNullable(num1, num2);
            //Console.WriteLine($"Result is {result}");

            /// Question 8 ///
            //int size;
            //Console.Write("Enter size of array: ");
            //int.TryParse(Console.ReadLine(), out size);
            //int[] arr = new int[size];
            //FillArray(arr);
            //Console.WriteLine($"Sum of even numbers in array is : {SumArrayEvenNumbers(arr)}");

            /// Question 9 ///
            //PrintGrades();

            /// Question 10 ///
            //int size;
            //Console.Write("Enter size of array: ");
            //int.TryParse(Console.ReadLine(), out size);
            //int?[] arr = new int?[size];
            //FillNullableArray(arr);
            //int? average = CalculateNullableAverage(arr);
            //Console.WriteLine($"Average is : {average}");
        }

        #region Helper Functions
        static int? GetNullableInt(int num , bool parsed)
        {
            int? result;
            if (num == 0 && !parsed)
                result = null;
            else
                result = num;
            return result;
        }
        static bool CheckZero(float value)
        {
            if (value == 0) return true;
            return false;
        }
        static void FillNullableArray(int?[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter item num {i + 1} : ");
                int value;
                bool isParsed =  int.TryParse(Console.ReadLine(), out value);
                if(value == 0 && !isParsed) 
                    arr[i] = null;
                else
                    arr[i] = value;
            }
        }
        static void FillArray(int[] arr)
        {
            bool isParsed;
            for (int i = 0; i < arr.Length; i++)
            {
                do
                {
                    Console.Write($"Enter item num {i + 1} : ");
                    isParsed = int.TryParse(Console.ReadLine(), out arr[i]);
                }
                while (!isParsed);
                

            }
        }
        #endregion

        #region Question 1
        static string CheckEligible(int age , string nationality)
        {
            if (age >= 18 && nationality.ToLower() == "egyptian")
            {
                return "Eligible";
            }
            else
            {
                return "Not Eligible";
            }

        }
        #endregion

        #region Question 2
        static void Calculator(float num1 , float num2, char op)
        {
            float result = 0;
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"{num1} {op} {num2} = {result}");
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"{num1} {op} {num2} = {result}");
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"{num1} {op} {num2} = {result}");
                    break;
                case '/':
                    result = num1 / num2;
                    Console.WriteLine($"{num1} {op} {num2} = {result}");
                    break;
                default:
                    Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
                    break;
            }
        }
        #endregion

        #region Question 3
        static void PrintMultiplicationTable(int n)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {n} = {i * n}");
            }
        }
        #endregion

        #region Question 4
        static bool CheckPrime(int num)
        {
            int M = num / 2;
            for(int i =1; i < M; i++ )
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void PrintPrimeNumbers(int[] numbers)
        {
            foreach(int n in numbers)
            {
                if(CheckPrime(n))
                {
                    Console.Write($"{n} ");
                }
            }
            
        }
        #endregion

        #region Question 5
        static void FindMaxandIndex(int[] arr, out int max, out int maxIndex)
        {
            max = int.MinValue;
            maxIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }
        }
        #endregion

        #region Question 6
        enum PalindromeStatus
        {
            NotPalindrome,
            Palindrome
        }
        static PalindromeStatus isPalindrome(string word)
        {
            int leftPtr = 0;
            int rightPtr = word.Length - 1;
            while (leftPtr <= rightPtr)
            {
                if (word[leftPtr].ToString().ToLower() != word[rightPtr].ToString().ToLower())
                {
                    return PalindromeStatus.NotPalindrome;
                }
                leftPtr++;
                rightPtr--;
            }
            return PalindromeStatus.Palindrome;
        }
        #endregion

        #region Question 7
        static int? DivideNullable(int? num1 , int? num2)
        {
            if (num1 != null && num2 != null)
            {
                return num1.Value / num2.Value;
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region Question 8
        static int SumArrayEvenNumbers(int[] arr)
        {
            int sum = 0;
            foreach(int num in arr)
            {
                if(num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
        #endregion

        #region Question 9
        static void PrintGrades()
        {
            int[] studGrades = new int[5];
            char[] studAssigned = new char[5];
            for(int i = 0; i < 5; i++)
            {
                do
                {
                    Console.Write($"Enter Student {i + 1} grade: ");
                    studGrades[i] = int.Parse(Console.ReadLine());

                } while (studGrades[i] < 1 || studGrades[i] > 100);
                switch (studGrades[i])
                {
                    case int when studGrades[i] >= 90:
                        studAssigned[i] = 'A';
                        break;
                    case int when studGrades[i] >= 80:
                        studAssigned[i] = 'B';
                        break;
                    case int when studGrades[i] >= 70:
                        studAssigned[i] = 'C';
                        break;
                    case int when studGrades[i] >= 60:
                        studAssigned[i] = 'D';
                        break;
                    case int when studGrades[i] < 60:
                        studAssigned[i] = 'F';
                        break;
                }
            }
            for (int i = 0; i < studAssigned.Length; i++)
            {
                Console.WriteLine($"Student {i + 1} Assigned Grade is : {studAssigned[i]}");
            }
        }
        #endregion

        #region Question 10
        static int? CalculateNullableAverage(int?[] arr)
        {
            int sum = 0;
            int countnotNull = 0;
            for(int i =0; i < arr.Length; i++)
            {
                if(arr[i] != null)
                {
                    sum += arr[i].Value;
                    countnotNull++;
                }
            }
            if(sum > 0)
            {
                return sum / countnotNull;
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
