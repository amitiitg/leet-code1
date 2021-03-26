using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas.Medium
{
    public class GenerateParans
    {
        public IList<string> GenerateParenthesis(int n)
        {
            return GenerateParanthesisInternal(n, 0, "");
        }

        public List<string> GenerateParanthesisInternal(int open, int closed, string input)
        {
            if (open == 0 && closed == 0)
            {
                return new List<string>() { input };
            }

            List<string> opr = null, cpr = null, result = new List<string>();
            if (open > 0)
            {
                opr = GenerateParanthesisInternal(open - 1, closed + 1, input + '(');
            }

            if (closed > 0)
            {
                cpr = GenerateParanthesisInternal(open, closed - 1, input + ')');
            }

            if (opr != null)
            {
                result.AddRange(opr);
            }

            if (cpr != null)
            {
                result.AddRange(cpr);
            }

            return result;
        }
    }
}
