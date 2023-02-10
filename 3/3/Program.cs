

using System;

namespace Solution
{
    public class Solution
    {
        public static int solution(int A, int B)
        {
            
            var AA = A.ToString() + "";
            var BB = B.ToString() + "";
            var C = "";
            int result;
            var v = true;
            while (v == true)
            {
                if (AA.Length > 0 || BB.Length > 0)
                {
                    if (AA.Length > 0)
                    {
                        C = C + AA[0].ToString();
                        AA = AA.Substring(1, AA.Length - 1);
                    }
                    if (BB.Length > 0)
                    {
                        C = C + BB[0].ToString();
                        BB = BB.Substring(1, BB.Length - 1);
                    }
                    else
                    {
                        v = false;
                    }
                }
            }
            result = int.Parse(C);
            return result;
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Result" + Solution.solution(12345, 678).ToString());
        }
    }
}
