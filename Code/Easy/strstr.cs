
namespace TestIdeas
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class strstr
    {
        public int StrStr(string haystack, string needle)
        {
            int hI = 0, nI = 0, currLength = 0;

            if (needle.Length == 0)
            {
                return 0;
            }

            while (hI < haystack.Length)
            {
                if (haystack[hI] != needle[nI])
                {
                    if (currLength == 0) ++hI;
                    else
                    {
                        hI = hI - currLength + 1;
                        nI = 0;
                        currLength = 0;
                    }
                }
                else
                {
                    hI++;
                    nI++;
                    currLength++;
                    if (currLength == needle.Length)
                    {
                        return hI - currLength;
                    }
                }
            }

            return -1;
        }
    }
}
