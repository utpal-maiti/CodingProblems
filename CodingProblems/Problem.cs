using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    public class Problem
    {
        #region RomanToInt
        public static void RomanToInt_TEST()
        {

            int result1 = RomanToInt("III");
            Console.WriteLine($"{result1}"); // Output:3

            int result2 = RomanToInt("LVIII");
            Console.WriteLine($"{result2}"); // Output:58


            int result3 = RomanToInt("MCMXCIV");
            Console.WriteLine($"{result3}"); // Output:1994
        }

        private static int RomanToInt(string s)
        {
            Dictionary<char, int> romanMap = new Dictionary<char, int>{
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}

        };
            int total = 0;
            int prevValue = 0;
            // for(int i=0;i<s.Length;i++){
            //     if(i+1<s.Length && romanMap[s[i]]<romanMap[s[i+1]]){
            //         total=total-romanMap[s[i]];
            //     }else{
            //         total+=romanMap[s[i]];
            //     }
            // }

            foreach (char c in s)
            {
                int currentValue = romanMap[c];
                total += currentValue;

                if (prevValue < currentValue)
                {
                    total -= 2 * prevValue;
                }
                prevValue = currentValue;
            }
            return total;
        }
        #endregion

        #region IsPalindrome
        public static void IsPalindrome_TEST()
        {

            bool result1 = IsPalindrome(121);
            Console.WriteLine($"{result1}"); // Output:true

            bool result2 = IsPalindrome(-121);
            Console.WriteLine($"{result2}"); // Output:false


            bool result3 = IsPalindrome(10);
            Console.WriteLine($"{result3}"); // Output:false
        }
        private static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            int original = x;
            int reversed = 0;

            while (x != 0)
            {
                int digit = x % 10;
                reversed = reversed * 10 + digit;
                x = x / 10;
            }

            return original == reversed;
        }
        #endregion

        #region TwoSum

        private static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numDict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numDict.ContainsKey(complement))
                {
                    return new int[] { numDict[complement], i };
                }
                numDict[nums[i]] = i;
            }

            throw new ArgumentException("No two sum solution");
        }
       public static void TwoSum_TEST()
        {
          
            int[] result1 = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine($"[{result1[0]}, {result1[1]}]"); // Output: [0, 1]

            int[] result2 =TwoSum(new int[] { 3, 2, 4 }, 6);
            Console.WriteLine($"[{result2[0]}, {result2[1]}]"); // Output: [1, 2]

            int[] result3 = TwoSum(new int[] { 3, 3 }, 6);
            Console.WriteLine($"[{result3[0]}, {result3[1]}]"); // Output: [0, 1]
        }
        #endregion


        #region LongestCommonPrefix
        public static void LongestCommonPrefix_TEST()
        {
            string[] strs1 = { "flower", "flow", "flight" };
            string[] strs2 = { "dog", "racecar", "car" };
            string[] strs3 = { "a" };

            //Console.WriteLine(LongestCommonPrefix(strs1));  // Output: "fl"
            //Console.WriteLine(LongestCommonPrefix(strs2));  // Output: ""
            Console.WriteLine(LongestCommonPrefix(strs3));  // Output: "a"
        }

        private static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";

            string shortestStr = strs[0];
            foreach (string str in strs)
            {
                if (str.Length < shortestStr.Length)
                    shortestStr = str;
            }

            for (int i = 0; i < shortestStr.Length; i++)
            {
                char currentChar = shortestStr[i];
                foreach (string str in strs)
                {
                    if (str[i] != currentChar)
                        return shortestStr.Substring(0, i);
                }
            }

            return shortestStr;
        }
        #endregion
    }
}