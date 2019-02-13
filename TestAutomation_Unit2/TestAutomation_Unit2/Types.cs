using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation_Unit2
{
    class Types
    {
        private string str;

        public void getConvertedStr(string str)
        {
            string[] words = str.Split(' ');
            int sum = 0;

            foreach (var word in words)
            {
                int result = Convert.ToInt32(word);

                System.Console.WriteLine($"<{result}>");

                sum += result;
            }

            System.Console.WriteLine(sum);
        }

        public int calc(int firstNum, string operation, int secondNum)
        {
           int result;

            switch (operation)
            {
                case "+":
                    return result = firstNum + secondNum;
                case "-":
                    return result = firstNum - secondNum;
                case "*":
                    return result = firstNum * secondNum;
                case "/":
                    return result = firstNum / secondNum;
                default:
                    return result = 0;
            }

        }
    }
}
