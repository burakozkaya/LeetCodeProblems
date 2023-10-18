namespace LengthOfLastWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.LengthOfLastWord("          Hello, World!     "));
        }
        public class Solution
        {
            public int LengthOfLastWord(string s)
            {
                s = s.Trim();
                var temp = s.Split(' ');
                return temp[temp.Length - 1].Length;
            }
        }
    }
}