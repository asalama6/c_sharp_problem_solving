using System;
internal class Program
{
    public static void Main(string[] args)
    {
        /*
                                   Given a number N. Determine whether N is float number or integer number.
 
                If N is float number print "float".
 
                If N is integer number print "int".
 
                Input
                Only one line containing a number N (1≤N≤103
                )
 
                Output
                Print the answer required above.
 
                Examples
                inputCopy
                15.00
                outputCopy
                int
                inputCopy
                87.4
                outputCopy
                float
 
 
        */


        #region problem Solving
        string input = Console.ReadLine();
        string[]Ad=input.Split('.');
        int num =int.Parse( Ad[1]);
        if (num > 1)
            Console.WriteLine("float");
        else Console.WriteLine("int");
        #endregion
    }
}