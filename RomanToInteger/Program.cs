namespace RomanToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string romanNumeral = "IX";
            int result = solution.RomanToInt(romanNumeral);
            Console.WriteLine($"Roman numeral {romanNumeral} is equivalent to {result} in Arabic numerals.");
        }
        public class Solution
        {
            public int RomanToInt(string s)
            {
                var temp = 0;
                var tempList = s.ToCharArray();
                var dictionary = new Dictionary<char, int>
                {
                    {'I',1 },
                    {'V',5 },
                    {'X',10 },
                    {'L',50 },
                    {'C',100 },
                    {'D',500 },
                    {'M',1000 }
                };
                for (var i = 0; i < tempList.Length; i++)
                {
                    if (i + 1 == tempList.Length)
                    {
                        temp += dictionary[tempList[i]];
                        break;
                    }
                    if (dictionary[tempList[i]] >= dictionary[tempList[i + 1]])
                        temp += dictionary[tempList[i]];
                    else
                        temp -= dictionary[tempList[i]];
                }
                return temp;
            }
        }
    }
}