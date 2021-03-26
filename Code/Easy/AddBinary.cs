using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas.Easy
{
    class AddBinary
    {
        public string AddBinary1(string a, string b)
        {
            if (a.Length < b.Length)
            {
                var tmp = a;
                a = b;
                b = tmp;
            }

            // a > b
            var resArr = new char[a.Length + 1];
            var resIdx = a.Length;
            var carry = 0;
            for (int i = a.Length - 1; i >= 0; --i)
            {
                var j = b.Length - a.Length + i;
                if (j < 0)
                {
                    resArr[resIdx--] = ((a[i] - '0' + carry) % 2 == 0) ? '0' : '1';
                    carry = (a[i] - '0' + carry) / 2;
                }
                else
                {
                    resArr[resIdx--] = ((a[i] - '0' + b[j] - '0' + carry) % 2 == 0) ? '0' : '1';
                    carry = (a[i] - '0' + b[j] - '0' + carry) / 2;
                }
            }

            if (carry == 1)
            {
                resArr[0] = '1';
                return new string(resArr);
            }
            else
            {
                return new string(resArr, 1, a.Length);
            }
        }
    }
}
