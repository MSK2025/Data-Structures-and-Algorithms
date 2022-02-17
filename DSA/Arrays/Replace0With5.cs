namespace DSA.Arrays
{
    /*
        Problem Statement:
        You are given an integer N. You need to convert all zeroes of N to 5.
        Example 1:
            Input:
                N = 1004
            Output: 1554
                Explanation: There are two zeroes in 1004 on replacing all zeroes with "5", the new number will be "1554".
        Example 2:
            Input:
                N = 121
            Output: 121
                Explanation: Since there are no zeroes in "121", the number remains as "121". 
     */
    public class Replace0With5
    {
        public int ConvertFiveRec(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                int lastDigit = number % 10;
                if (lastDigit == 0)
                {
                    lastDigit = 5;
                }
                int nextNumber = number / 10;

                return ConvertFiveRec(nextNumber) * 10 + lastDigit; ;

            }
        }
        public int ConvertFive(int number)
        {
            // If given number itself is 0 then return with 5 else call rec function to traverse the number. 
            if(number == 0)
            {
                return 5;
            }
            else
            {
                return ConvertFiveRec(number);

            }           
        }

    }
}
