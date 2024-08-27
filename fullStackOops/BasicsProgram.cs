﻿using System.Diagnostics.CodeAnalysis;

namespace fullStackOops
{
    public class BasicsProgram
    {
        public static void Main(string[] args)
        {

            //Problems
            //Q.no.1: WAC#P to compare any two strings

            /* string name1 = "Dipesh";
             string name2 = "Deula";
             int compareString = name1.CompareTo(name2);
             if (compareString == 0)
             {
                 Console.WriteLine("Both strings are equal");
             }
             else {
                 Console.WriteLine("Not a equal strings");
             }*/

            //Q.no.2: WAC#P to find sum of two numbers.
            /* Console.Write("Enter the first number: ");
             int num1 =Convert.ToInt32(Console.ReadLine());
             Console.Write("Enter the second number: ");
             int num2 = Convert.ToInt32(Console.ReadLine());
             int sum = num1 + num2;
             Console.WriteLine($"The sum of num1={num1} and num2={num2} is : "+sum);*/

            //Q.no.3: WAC#P to find product of two numbers.
            /* Console.Write("Enter the first number: ");
             int num1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("Enter the second number: ");
             int num2 = Convert.ToInt32(Console.ReadLine());
             int product = num1 * num2;
             Console.WriteLine($"The product of num1={num1} and num2={num2} is : " + product);*/

            //Q.no.4: WAC#P to find simple interest.[si=(p*t*r)/100]

            /* Console.Write("Enter the Principal Amount:");
             double principal = Convert.ToDouble(Console.ReadLine());

             Console.Write("Enter the Time : ");
             double time = Convert.ToDouble(Console.ReadLine());

             Console.Write("Enter the Rate: ");
             double rate = Convert.ToDouble(Console.ReadLine());

             double simpleInterest = (principal * rate * time) / 100;

             Console.WriteLine("Simple Interest: "+simpleInterest);*/

            //Q.no.5: wap to find the area of circle. [area = pi * r * r] use pi as constant

            /*Console.Write("Enter the value of radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radius * radius;

            Console.WriteLine("The area of circle is : " + area);*/

            //Q.no.6: WAC#P to find the largest among two numbers
            /*Console.WriteLine("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"The largest number is {firstNumber} i.e firstNumber");
            }
            else {
                Console.WriteLine($"The largest number is {secondNumber} i.e secondNumber");
            }
            */
            //Q.no.7: WAC#P to find the smallest among two numbers
            /* Console.WriteLine("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"The smallest number is {secondNumber} i.e firstNumber");
            }
            else {
                Console.WriteLine($"The smallest number is {firstNumber} i.e secondNumber");
            }*/

            //Q.no.8: WAC#P to find the largest among three numbers
            /* Console.Write("Enter the first number: ");
             int firstNumber = Convert.ToInt32(Console.ReadLine());

             Console.Write("Enter the second number: ");
             int secondNumber = Convert.ToInt32(Console.ReadLine());

             Console.Write("Enter the third number: ");
             int thirdNumber = Convert.ToInt32(Console.ReadLine());

             if (firstNumber > secondNumber && firstNumber > thirdNumber)
             {
                 Console.WriteLine($"The largest number is {firstNumber} i.e firstNumber");
             }
             else if (secondNumber > thirdNumber)
             {

                 Console.WriteLine($"The largest number is {secondNumber} i.e secondNumber");
             }


             else
             {
                 Console.WriteLine($"The largest number is {thirdNumber} i.e thirdNumber");
             }*/

            //Q.no.9: WAC#P to find the smallest among two numbers

            /* Console.Write("Enter the first number: ");
             int firstNumber = Convert.ToInt32(Console.ReadLine());

             Console.Write("Enter the second number: ");
             int secondNumber = Convert.ToInt32(Console.ReadLine());

             Console.Write("Enter the third number: ");
             int thirdNumber = Convert.ToInt32(Console.ReadLine());

             if (firstNumber < secondNumber && firstNumber < thirdNumber)
             {
                 Console.WriteLine($"The smallest number is {firstNumber} i.e firstNumber");
             }
             else if (secondNumber < thirdNumber)
             {

                 Console.WriteLine($"The smallest number is {secondNumber} i.e secondNumber");
             }

             else
             {
                 Console.WriteLine($"The smallest number is {thirdNumber} i.e thirdNumber");
             }
            */
            //Q.no.10: WAC#P to check whether a number is odd or even
            /* Console.Write("Enter the number: ");
             int num = Convert.ToInt32(Console.ReadLine());
             bool isOddEven = false;

             if (num % 2 == 0)
             {
                 isOddEven = true;

             }
             else { 
                 isOddEven = false;

             }

             if (isOddEven)
             {
                 Console.WriteLine($"The {num} is Even number");
             }
             else {
                 Console.WriteLine($"The {num} is Odd number");
             }*/

            //Q.no.11: WAC#P to check whether a number is divisible by 7 or not;
            /*Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isDivisibleBySeven = false;

            if (number % 7 == 0)
            {
                isDivisibleBySeven = true;
            }
            else
            {
                isDivisibleBySeven = false;
            }

            if (isDivisibleBySeven)
            {
                Console.WriteLine($"The {number} is divisible by 7");

            }
            else
            {
                Console.WriteLine($"The {number} is not divisible by 7");

            }*/

            //Q.no.12: WAC#P to check whether a number is exactly by 5 and 10
            /*Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isExactltByFiveAndTen = false;

            if (number % 5 == 0 && number % 10 ==0)
            {
                isExactltByFiveAndTen = true;
            }

            if (isExactltByFiveAndTen)
            {
                Console.WriteLine($"The {number} is exactly by 5 and 10");

            }
            else
            {
                Console.WriteLine($"The {number} is not exactly by 5 and 10");

            }*/

            //Q.no.13: WAC#P to check whether a number is divisible by 7 but not by 13.
            /*Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32 (Console.ReadLine());
            bool isDivisibleBySevenNotThirteen = false;

            if (number % 7 == 0 && number % 13 != 0)
            {
                isDivisibleBySevenNotThirteen = true;
            }
            if (isDivisibleBySevenNotThirteen)
            {
                Console.WriteLine($"The {number} is divisible by 7 but not by 13");
            }
            else {
                Console.WriteLine($"The {number} is not divisible by 7 also not by 13");
            }*/

            //Q.no.14: WAC#P to input CP and SP and check profit or loss. Also find profit or loss Amount
            /* Console.Write("Enter the CP: ");
             int CP = Convert.ToInt32(Console.ReadLine());

             Console.Write("Enter the SP: ");
             int SP = Convert.ToInt32(Console.ReadLine());

             double profit, loss, profitAmount, lossAmount;
             bool isProfitLoss = false;

             if (CP > SP)
             {

                 isProfitLoss = true;
             }


             if (isProfitLoss)
             {
                 loss = CP - SP;
                 lossAmount = (loss / CP) * 100;

                 Console.WriteLine($"Loss :{loss}, lossAmount:{lossAmount}");

             }
             else {
                 profit = SP - CP;
                 profitAmount = (profit / CP) * 100;

                 Console.WriteLine($"profit :{profit}, profitAmount:{profitAmount}");


             }*/

            //Q.no.15: WAC#P to find print numbers from 1 to 100.
            /*
                        Console.WriteLine("Numbers from 1 to 100");
                        for (int i = 1; i <= 100; i++)
                        {
                            Console.WriteLine(i);
                        }*/

            //Q.no.16: WAC#P to find sum of numbers from 5 to 100.
            /*Console.WriteLine("Sum of numbers from 5 to 100 :");
            int sum = 0;
            for (int i = 5; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum of number 5 to 100 :" + sum);*/

            //Q.no.17: WAC#P to check whether a number is prime or not.
            /* Console.Write("Enter the number:");
             int num = Convert.ToInt32(Console.ReadLine());
             bool isPrime = true;

             for (int i = 2; i < num / 2; i++)
             {
                 if (num % i == 0)
                 {
                     isPrime = false;
                     break;
                 }
             }

             if (isPrime)
             {

                 Console.WriteLine($"The number {num} is prime");
             }
             else
             {
                 Console.WriteLine($"The number {num} is not prime");
             }
            */

            // Q.no.17: WAC#P to print prime numbers from 1 to 100
            // Console.WriteLine("Prime numbers from 1 to 100:");

            // Method to check if a number is prime
            /* bool IsPrime(int number)
             {
                 if (number <= 1) return false;
                 if (number == 2) return true;
                 if (number % 2 == 0) return false;

                 for (int i = 3; i <= Math.Sqrt(number); i += 2)
                 {
                     if (number % i == 0) return false;
                 }

                 return true;
             }


             for (int i = 1; i <= 100; i++)
             {
                 if (IsPrime(i))
                 {
                     Console.WriteLine(i);
                 }
             }
 */
            //Q.no.18: WAC#P to print Fibonacci series upto n terms.
            /*Console.WriteLine("Enter the value of n:");
            int number = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 1;
            int c;

            for (int i = 0; i < number; i++)
            {
                c = a + b;
                a = b;
                b = c;

                Console.WriteLine(c);
            }*/

            //Q.no.19: WAC#P to find the factorial of any number.
            /*Console.Write("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;

            }
            Console.WriteLine($"The factorial of {num} is {fact}");
*/
            //Q.no. 20: WAC#P to generate multiplication table from 1 to 10.
            /* Console.Write("Enter the number:");
             int num = Convert.ToInt32 (Console.ReadLine());

             for (int i = 1; i <= 10; i++) 
             {
                 int multiplication = num * i;

                 Console.WriteLine(num + "X" + i + "=" + multiplication);
             }*/

            //Q.no.21: WAC#P to find the reverse of a number.
            /* Console.WriteLine("Enter a number:");
             int number = Convert.ToInt32(Console.ReadLine());

             int reverse = 0;

             while(number != 0)
             {
                 int rem = number % 10;
                 reverse = reverse * 10 + rem;
                 number = number / 10;
             }

             Console.WriteLine($"The reverse of a number is : {reverse}");
 */
            //Q.no.22: WAC#P to check whether a number is palindrome or not.
            /*  Console.Write("Enter a number:");
              int number = Convert.ToInt32(Console.ReadLine());
              int temp = number;

              int reverse = 0;

              while (number != 0)
              {
                  int rem = number % 10;
                  reverse = reverse * 10 + rem;
                  number = number / 10;
              }

              if (temp == reverse)
              {
                  Console.WriteLine($"The given number is palindrome i.e {reverse}");
              }
              else {
                  Console.WriteLine($"The given number is not palindrome i.e {reverse}");
              }*/
            //Q.no.23: WAC#P to find the sum of digits of a number.
            /* Console.WriteLine("Enter a number:");
             int number = Convert.ToInt32(Console.ReadLine());
             int sum = 0;

             while (number != 0)
             {
                 int rem = number % 10;
                 sum += rem;
                 number = number / 10;
             }

             Console.WriteLine($"The sum of digits of a number is : {sum}");*/

            //Q.no.24: WAC#P to find sum of 20 numbers in an array
            /* Console.Write("Enter the numbers:");
             int[] nums = new int[20];
             int Sum = 0;

             for (int i = 0; i < 20; i++)
             {
                 nums[i] = Convert.ToInt32(Console.ReadLine());
                 Sum += nums[i];
             }
             Console.WriteLine($"The sum of 20 numbers in array is : {Sum}");*/

            //Q.no.25: WAC#P to find maximum and minimum number from array
            Console.Write("Enter the size of array:");
            int numArray = Convert.ToInt32(Console.ReadLine());

            int[] arrayMaxMin = new int[numArray];
           // int Max = 0;
            Console.WriteLine("Enter your arrray nums: ");

            //taking user input array numbers
            for (int i = 0; i < numArray; i++)
            {
                arrayMaxMin[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array num:");
            for (int i = 0; i < numArray; i++)
            {
                Console.Write(arrayMaxMin[i]+" ");
                
            }
            Console.WriteLine("\n");

           

            int MaxNumber = arrayMaxMin.Max();
            int MinNumber = arrayMaxMin.Min();
            Console.WriteLine("Max num: "+MaxNumber);
            Console.WriteLine("Max num: " + MinNumber);


        }

    }
}
