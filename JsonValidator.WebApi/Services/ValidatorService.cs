using System;
using System.Collections.Generic;
using System.Linq;

namespace JsonValidator.WebApi.Services
{
    public class ValidatorService
    {
        public Tuple<bool, string> JsonValidator(string input)
        {
            //Making reference for the required brackets that we need to validate.
            Dictionary<char, char> bracketLookup = new Dictionary<char, char>()
            {
            { '{', '}' },
            { '[', ']' }
        };

            Stack<char> brackets = new Stack<char>();
            char currentChar = ' ';
            try
            {
                foreach (char c in input)
                {
                    //Save the opening brackets in a stack which provide us with First in
                    //Last out option
                    if (bracketLookup.Keys.Contains(c))
                    {
                        brackets.Push(c);
                    }
                    //Check if there is closing bracket at the json
                    else if (bracketLookup.Values.Contains(c))
                    {
                        //Match the closing with the opening bracket
                        currentChar = c;
                        if (c == bracketLookup[brackets.First()])
                        {
                            //if they are equal pop the opening
                            //to be removed from the stack and the behind one ready for matching
                            brackets.Pop();
                        }
                        else
                        {
                            var errorMessage = c + " is a closing without a proper opening";
                            return Tuple.Create(false, errorMessage);
                        }
                    }
                    else continue;
                }
            }
            catch
            {
                return Tuple.Create(false, currentChar + " has no opening");
            }
            char output = ' ';
            if (brackets.Count() > 0)
            {
                output = bracketLookup[brackets.First()];
            }

            return brackets.Count() == 0 ? Tuple.Create(true, "Json is Valid") : Tuple.Create(false, output + " is an opening without closure");
        }
    }
}