using System;
using System.Collections.Generic;

namespace Assignment
{
    public class StudentSolution
    {
        #region Lecture

        public int LCT01_RecursiveFactorial(int n)
        {
            return Factorial(n);
        }

        private int Factorial(int n)
        {
            // factorial(5) = 5 + 4 .. 1 => 5 + fact(4)
            if (n == 0) return 1; // base case
            if (n == 1) return 1; // base case
            return n * Factorial(n - 1); // recursive case
        }

        public int LCT02_RecursiveFibonacci(int n)
        {
            return Fibonacci(n);
        }

        private int Fibonacci(int n)
        {
            // base case
            if (n == 0) return 0; // base case
            if (n == 1) return 1; // base case

            //fib(5) = fib(4) + fib(3)
            //fib(4) = fib(3) + fib(2)
            //fib(2) = fib(1) + fib(0)
            //fib(n) = fib(n-1) + fib(n-2)
            return Fibonacci(n-1) + Fibonacci(n-2);// recursive case
        }

        public int LCT03_RecursiveSumOfOneToN(int n)
        {
            // n = 5 => 5 + 4 + 3 + 2 + 1
            //       => 5 + sum(4)
            //              => 4 + sum(3)
            //                      => n + sum(n-1)
            // base case                   => 2 + sum(1)
            return SumOfOneToN(n);
        }

        private int SumOfOneToN(int n)
        {
            // base case
            // if(n == 0) return 0;
            // if(n == 1) return 1;
            if(n <= 1) return n;

            // recursive case
            return n + SumOfOneToN(n - 1);
        }

        public int LCT04_RecursiveSumOfNumbers(int[] numbers)
        {
            return SumOfNumbers(numbers, 0);
        }

        private int SumOfNumbers(int[] numbers, int index)
        {
            // numbers = [1, 2, 3, 4, 5]
            // sum = numbers[0] + numbers[1] + ... + numbers[4]
            // sum = numbers[n-1] + numbers[n-2] + ... + numbers[0]
            // sum = numbers[n-1] + sum(n-2)
            // base case
            if (index >= numbers.Length) return 0;

            // recursive case
            return numbers[index] + SumOfNumbers(numbers, index + 1);
        }

        #endregion

        #region Assignment

        public int ASN01_RecursivePower(int baseNum, int exponent)
        {
            return Power(baseNum, exponent);
        }

        private int Power(int baseNum, int exponent)
        {
            return -1;
        }

        public bool ASN02_IsPalindrome(string str)
        {
            return IsPalindrome(str, 0, str.Length - 1);
        }

        private bool IsPalindrome(string str, int start, int end)
        {
            return false;
        }

        public int ASN03_RecursiveGCD(int a, int b)
        {
            return GCD(a, b);
        }

        private int GCD(int a, int b)
        {
            return -1;
        }

        public int ASN04_RecursiveBinarySearch(int[] arr, int target)
        {
            return BinarySearch(arr, target, 0, arr.Length - 1);
        }

        private int BinarySearch(int[] arr, int target, int low, int high)
        {
            return -1;
        }

        #endregion

    }
}