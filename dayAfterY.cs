using System;
internal class Program
{
    public static void Main(string[] args)
    {
        /*
                                Days of the week are numbered from 0
                     to 6
                    . You're given the current day number X
                    .

                    Find the day number after Y
                     days.

                    Saturday corresponds to 0
                    .
                    Sunday corresponds to 1
                    .
                    Monday corresponds to 2
                    .
                    ...
                    Friday corresponds to 6
                    .
                    Input
                    The first line of input contains two integers X,Y
                     (0≤X≤6)
                    , (0≤Y≤106)
                    .

                    Output
                    Find the day number after Y
                     days.

                    Examples
                    input
                    0 1
                    output
                    1
                    input
                    0 3
                    output
                    3
                    input
                    0 7
                    output
                    0   
        */


        #region problem Solving
        string input = Console.ReadLine();
       string[] numbers = input.Split(' ');
        int x = int.Parse(numbers[0]);
        int y = int.Parse(numbers[1]);
        if (x + y >= 7)
            Console.WriteLine((x + y) % 7);
        else
            Console.WriteLine((x + y));
        #endregion
    }
} 