using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterMind.App
{
    public class MasterMindLogic
    {
        public static string ReceiveCode(int level)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                sb.Append((char)('A' + new Random().Next(level + 2)));
            }

            string code = sb.ToString();
            return code;
        }

        public static string GetGuessFeedback(string code, string input)
        {
            var inputList = input.ToCharArray().ToList();
            var output = new StringBuilder();
            for (var i = 0; i < 4; i++)
            {
                var codeCharacter = code[i];

                if (codeCharacter == input[i])
                {
                    output.Append('P');
                    inputList[i] = 'X';
                }
                else if (inputList.Contains(codeCharacter))
                {
                    var index = inputList.IndexOf(codeCharacter);
                    if (input[index] != code[index])
                    {
                        output.Append('C');
                    }
                }
            }

            return new string(output.ToString().OrderByDescending(t => t).ToArray());
        }
    }
}