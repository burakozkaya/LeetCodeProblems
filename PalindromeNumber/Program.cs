namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.IsPalindrome(1001));
        }
        public class Solution
        {
            public bool IsPalindrome(int x)
            {
                var temp = x;
                var reverseNum = 0;
                var count = 0;
                if (x < 0)
                    return false;
                if (x == 0)
                    return true;
                while (temp > 0)
                {
                    reverseNum *= 10;
                    reverseNum += temp % 10;
                    temp /= 10;
                }

                if (reverseNum == x)
                    return true;
                return false;
            }
        }
    }
}