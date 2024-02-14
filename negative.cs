using System;
internal class Program
{
    public static void Main(string[] args)
    {
        /*
                         Muhammad always wants the best for you

                        So you have to solve this problem

                        You will take three numbers, you will print the largest number less than zero .

                        Input
                        only A,B and C (-109
                        <=A,B,C<=109
                        ).

                        Output
                        print the largest number less than zero

                        Examples
                        input
                        15 -1 -2
                        output
                        -1
                        input
                        15 0 -1
                        output
                        -1
 
 
        */


        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        int num1 = Convert.ToInt32(numbers[0]);
        int num2 = Convert.ToInt32(numbers[1]);
        int num3 = Convert.ToInt32(numbers[2]);
        int[]Numbers= new int[3] {num1,num2,num3};
        Array.Sort(Numbers);
        if (Numbers[2]<0)
        { 
            Console.WriteLine(Numbers[2]);
            
        }
        
        else if (Numbers[1] < 0)
        {
            Console.WriteLine(Numbers[1]);
        }
        else
        Console.WriteLine(Numbers[0]);

    }
}
