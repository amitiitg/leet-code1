using System;
using System.Collections.Generic;
using System.Text;

namespace TestIdeas
{
    public class ValidParanthesis
    {
        public bool isValid(string s)
        {
            var openParans = new HashSet<char>() { '(', '[', '{' };
            var closingParans = new Dictionary<char, char>()
            {
                { ')', '('},
                { '}', '{' },
                { ']', '[' }
            };

            Stack<char> openParansStack = new Stack<char>(1000);

            for (int i = 0; i < s.Length; ++i)
            {
                if (openParans.Contains(s[i]))
                {
                    openParansStack.Push(s[i]);
                }
                else
                {
                    if (openParansStack.Count == 0)
                    {
                        return false;
                    }
                    var popped = openParansStack.Pop();
                    if (closingParans.TryGetValue(s[i], out char value))
                    {
                        if (value != popped)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return openParansStack.Count == 0;
        }
    }
}
