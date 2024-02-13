using System;
internal class Program
{
    public static void Main(string[] args)
    {
        /*
                    Coach Hussein has many boxes placed next to each others. Each box has a fixed size. Coach Hussein asked AbuOkail to tell him the size of the 3rd
                     box from the right. You will be given the sizes as one positive number N
                    , each digit in the number represents the ith
                     box size.

                    Could you help him to determine the size of 3rd
                     box from the right.

                    For more clarification please read the notes below.

                    Input
                    Only one line contains an integer number N
                     where (111≤N≤1012−1)
                    , Each digit of this number is considered as a box size.

                    It's guarantee that each digit of number N
                     is greater than 0
                    .

                    Output
                    Print the size of the third box from the right.

                    Examples
                    input 
                    12345
                    output 
                    3
                    input 
                    778899
                    output 
                    8
                    Note
                    In the first example:

                    The size of the first box = 5
                    ,

                    The size of the second box = 4
                    ,

                    The Size of the third box = 3
                    ,

                    The Size of the fourth box = 2
                    ,

                    The size of the fifth box = 1
                    .

                    So the answer is 3


        */


        #region problem Solving
        string input = Console.ReadLine();
        if (long.TryParse(input, out long numbers))
        {
            long number = Convert.ToInt64(input);

            Console.WriteLine((number % 1000) / 100);
        }
        #endregion
    }
} 