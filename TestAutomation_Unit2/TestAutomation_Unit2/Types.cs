using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation_Unit2
{
    class Types
    {
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

        public dynamic calc(int firstNum, string operation, int secondNum)
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
                    double div = (double)firstNum / secondNum;
                    return div; 
                default:
                    return result = 0;
            }
        }

        public string floatToString(params float[] floats)
        {
            string result="String: ";

            foreach (float value in floats)
            {
                result += Convert.ToString(value)+"  ";
            }
            return result;
        }

        public void convertStringToChars(string str)
        {
            char[] characters = str.ToCharArray();
            foreach (char chr in characters)
            {
                Console.WriteLine(chr);
            }
        }

        public string stringBoxing()
        {
            Console.WriteLine("Enter String value: ");
            object obj = Console.ReadLine();
            return "<"+(string)obj+">";
        }
    }
}
