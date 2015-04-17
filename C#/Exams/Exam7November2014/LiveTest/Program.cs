using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstStr = Console.ReadLine();
            string secondStr = Console.ReadLine();
            int diapazon = int.Parse(Console.ReadLine());

            int sumOfFirst = 0;
            int sumOfSecond = 0;

            for (int i = 0; i < firstStr.Length; i++)
            {
                sumOfFirst += firstStr[i];
            }
            for (int i = 0; i < secondStr.Length; i++)
            {
                sumOfSecond += secondStr[i];
            }
            //string firstLetterFirst = "";
            //string secondLetterFirst = "";

            //string firstLetterSecond = "";
            //string secondLetterSecond = "";
            bool isFind = false;
            int currentLeftSumFirst = 0;
            int currentRightSumFirst = sumOfFirst;

            int currentLeftSumSecond = 0;
            int currentRightSumSecond = sumOfSecond;
                for (int j = 0; j < firstStr.Length; j++)
                {
                    string leftFirstStr = firstStr.Substring(0, j+1);
                    string rightFirstStr = firstStr.Substring(j+1);
                    currentLeftSumFirst += firstStr[j];
                    currentRightSumFirst -= firstStr[j];

                    for (int k = 0; k < secondStr.Length; k++)
                    {
                        string leftSecondStr = secondStr.Substring(0, k+1);
                        string rightSecondStr = secondStr.Substring(k+1);
                        currentLeftSumSecond += secondStr[k];
                        currentRightSumSecond -= secondStr[k];

                        int currentDiapazonValue = Math.Abs(currentLeftSumFirst*currentRightSumSecond - currentLeftSumSecond*currentRightSumFirst);
                        if (currentDiapazonValue <= diapazon && currentDiapazonValue != 0 )
                        {
                            //firstLetterFirst += Convert.ToString(firstStr[j]);
                            //secondLetterFirst = Convert.ToString(firstStr.Remove(j));

                            //firstLetterSecond += Convert.ToString(secondStr[k]);
                            //secondLetterSecond = Convert.ToString(secondStr.Remove(k));
                            isFind = true;
                            Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs",leftFirstStr,rightFirstStr,
                                leftSecondStr,
                                rightSecondStr,currentDiapazonValue);
                        }
                    }
                   
                    currentLeftSumSecond = 0;
                    currentRightSumSecond = sumOfSecond;
                    
                }
                if (!isFind)
                {
                    Console.WriteLine("No");
                }
           
        }
    }
}
