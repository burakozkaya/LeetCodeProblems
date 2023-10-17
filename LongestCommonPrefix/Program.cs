using static LongestCommonPrefix.Program;

namespace LongestCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] input = new string[] { "flower", "flour", "floppy" };
            string result = solution.LongestCommonPrefix(input);
            Console.WriteLine(result);
        }
        public class Solution
        {
            public string LongestCommonPrefix(string[] strs)
            {
                string prefix = strs[0];
                for (var i = 1; i < strs.Length; i++)
                {
                    while (strs[i].IndexOf(prefix) != 0)
                    {
                        prefix = prefix.Substring(0, prefix.Length - 1);
                        if (prefix.Length == 0)
                            return string.Empty;
                    }
                }
                return prefix;
            }
        }
    }
}