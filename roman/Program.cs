using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roman
{
       public class solution
    {
        public int RomanToInt(string s)
        { 
            var b= new Dictionary<char, int>()
            {
            { 'I', 1},
            { 'V', 5},
            { 'X', 10},
            { 'L', 50},
            { 'C', 100},
            { 'D', 500},
            { 'M', 1000}
            };

            int result = 0;
            for (int i=0; i<s.Length; i++)
            {
                if(i<s.Length-1 && b[s[i]] < b[s[i+1]])
                {
                    result = result - b[s[i]];
                }
                else
                {
                    result = result + b[s[i]];
                }
            }

            return result;



        }

        static void Main(string[] args)
        {
            solution solution = new solution();
            Console.WriteLine(solution.RomanToInt("VII"));        }
    }
        
    
}
