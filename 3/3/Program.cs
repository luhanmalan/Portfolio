

using System;

namespace Solution
{
    class Program
    {

        public static int solution(int A, int B)
        {

            string AA = A + "";
            string BB = B + "";
            string C = "";
            int result;
            bool v = true;

            while (v == true)
            {
                if (AA.Length > 0 || BB.Length > 0)
                {
                    if (AA.Length > 0)
                    {  
                        C = C + AA.ElementAt(0);
                        AA = AA.Substring(0);
                    }

                    if (BB.Length > 0)
                    {
                        C = C + BB.ElementAt(0);
                        BB = BB.Substring(0);
                    }
                    else
                    {
                        v = false;
                    }
                }
            }
            result = Convert.ToInt32(C);
            return result;


        }

            static void Main(string[] args)
            {
            
                Console.WriteLine("Result" + solution(12345, 678));
                
            }
        
    }
}
