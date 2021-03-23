using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas
{
    class LCP
    {
        public string FindLCP(string[] strs)
        {
            if (strs.Length == 0)
            {
                return string.Empty;
            }

            var smallestStr = strs[0];
            foreach (var item in strs)
            {
                if (item.Length < smallestStr.Length)
                {
                    smallestStr = item;
                }
            }

            for (int i = smallestStr.Length; i > 0; --i)
            {
                var prefixToCheck = smallestStr.Substring(0, i);
                bool existsInAll = true;

                foreach (var item in strs)
                {
                    if (item.Substring(0, i) != prefixToCheck)
                    {
                        existsInAll = false;
                        break;
                    }
                }

                if (existsInAll)
                {
                    return prefixToCheck;
                }
            }

            return string.Empty;
        }
    }
}
