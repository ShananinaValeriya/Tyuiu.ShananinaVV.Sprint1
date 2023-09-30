using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShananinaVV.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            string[] words = value.Split(new char[] { ' ', ',', '.', '!', '?', '1', '2', '3', '4', 
                '5', '6', '7', '8', '9', '0' , '*', '(', ')', '@',
                '"', ':', ';', '%', '-', '_', '+', '&', '^', '<', '>', '/', '№',
                '~', '`', '|', '{', '}', '[', ']', '=', '#' }, StringSplitOptions.RemoveEmptyEntries);
            string result = string.Empty;

            foreach (string word in words)
            {
                char lastLetter = word[word.Length - 1];
                result += lastLetter;
            }

            return result;
        }
    }
}
