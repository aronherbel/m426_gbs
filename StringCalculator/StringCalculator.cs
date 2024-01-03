using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel.Design;

namespace StringCalculator
{
    public class StringCalculator
    {


        private int calledCount;

        public int CalledCount
        {
            get
            {
                return calledCount;
            }
        }


        public int Add(string numbers)
        {

            calledCount++;

            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }


            char[] defaultDelimiters = { ',', '\n' };

            int indexOfNewLine = numbers.IndexOf('\n');
            char[] customDelimiters;

            if (indexOfNewLine == 1 && !char.IsDigit(numbers[0]))
            {
                customDelimiters = numbers.Substring(0, indexOfNewLine).ToCharArray();
                indexOfNewLine++;
            }
            else
            {
                customDelimiters = defaultDelimiters;
                indexOfNewLine = 0;
            }

            char[] allDelimiters = defaultDelimiters.Concat(customDelimiters).ToArray();
            string[] numberArray = numbers.Substring(indexOfNewLine).Split(allDelimiters);


            int sum = 0;
            List<int> negativeList = new List<int>();

            foreach (string number in numberArray)
            {
                

                int num = int.Parse(number);

                

                if (num < 0)
                {
                    negativeList.Add(num);

                }
                else if(num <= 1000)
                {
                    sum += num;
                }
                
            }


            if (negativeList.Count > 0)
            {
                throw new InvalidOperationException($"Negatives not allowed: {string.Join(", ", negativeList)}");
            }
            else
            {
                return sum;
            }
        } 
    }
}
