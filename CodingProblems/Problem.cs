using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    public class Problem
    {


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