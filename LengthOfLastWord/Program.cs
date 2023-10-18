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
                bool valid = false;
                int count = 0;
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (s[i] == ' ')
                    {
                        if (valid == true)
                            break;
                        else
                            continue;
                    }
                    else
                    {
                        count++;
                        valid = true;
                    }
                }

                return count;
            }
        }
    }
}