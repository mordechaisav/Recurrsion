using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurrsion
{
    public static class Recurrsion
    {
        public static int Multiply(int a, int b)
        {
            if (b == 0)
            {
                return 0;
            }
            return a + Multiply(a, b-1);
        }
            
        public static int SumOfDigits(int n,int sum = 0)
        {
            if (n == 0)
            {
                return sum;
            }
            
            return SumOfDigits(n/10, sum + n % 10);
        }
        public static int Power(int num, int exp)
        {
            if (exp == 0) { return 1; }
            return num * Power(num, exp-1);
        }
        public static void Reversed(int num)
        {
            if (num < 10)
            {
                Console.Write(num);
                return;
            }
            Console.Write(num%10);
            Reversed(num / 10);
        }
        public static int FindSum(int[] arr, int n)
        {
            if (n == 0) { return 0; }
            
            return arr[n-1]+ FindSum(arr, n-1);

        }
        public static int Divide(int a, int b)
        {
            if (a < b)
            {
                return 0;
            }
            return 1 + Divide(a-b, b);
        }
        public static bool IsPalindrome(string str, int start, int end)
        {
            if (start >= end) return true;
            if (str[start] != str[end]) return false;
            return IsPalindrome(str, start + 1, end - 1);
        }
        public static string DecimalToBinary(int n)
        {
            if (n == 0) return "0";
            if (n == 1) return "1";
            return DecimalToBinary(n / 2) + (n % 2).ToString();
        }
        public static int Gcd(int a, int b)
        {
            if (b == 0) return a;
            return Gcd(b, a % b);
        }
        public static void evenNumbers(int n)
        {
            if (n <= 0) return;
            evenNumbers(n - 2);
            if (n % 2 == 0) Console.WriteLine(n);
        }
        public static int findMax(int[] arr, int n)
        {
            if (n == 1) return arr[0];

            int maxOfRest = findMax(arr, n - 1);

            if (arr[n - 1] > maxOfRest)
            {
                return arr[n - 1];
            }
            else
            {
                return maxOfRest;
            }
        }
        public static bool sequence(int[] arr, int n, int diff)
        {
            if (n == 1) return true;
            if (arr[n - 1] - arr[n - 2] != diff) return false;
            return sequence(arr, n - 1, diff);
        }





    }
}
