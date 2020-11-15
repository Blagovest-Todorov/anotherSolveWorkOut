using System;

namespace _20.betterSolvedWorklOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int numTrainingDays = int.Parse(Console.ReadLine());
            double RanKmsBaseDay = int.Parse(Console.ReadLine());
             // -> convert later in double not to lose information
             bool isSucceed = false;
             double currDayDistance = RanKmsBaseDay;
             double totalRanDistance = RanKmsBaseDay;

            for (int i = 1; i <= numTrainingDays; i++)
            {
                int currDayPercentage = int.Parse(Console.ReadLine());
                double currIncrementPercentage = (double)currDayPercentage / 100;
                currDayDistance += (currDayDistance * currIncrementPercentage);// curr day ran distance /
                totalRanDistance += currDayDistance;

                if (totalRanDistance >= 1000)
                {
                    isSucceed = true;
                    break;
                }

            }
            if (isSucceed)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(totalRanDistance - 1000)} more kilometers!");
            } 
            else // if isSucceed = false
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - totalRanDistance)} more kilometers");
            }

        }
    }
}
