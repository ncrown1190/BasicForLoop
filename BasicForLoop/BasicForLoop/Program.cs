// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/* Description
Prompt the user to enter a number.  Use a for-loop to calculate the sum of all the numbers from 1 to the number entered.
Example
>>Enter a number: <<100
>>5050
Would you like to continue (y/n)? <<y
>>Enter a number: <<20
>>210
Would you like to continue (y/n)? <<n
<<Goodbye!
*/

Console.WriteLine("\n ********** Sum of all the numbers using Basic for Loop *********! ");

bool continueAgain = true;
do
{
    //int givenNumber = 0;
    Console.Write("Please enter a whole number: ");
    int givenNumber = int.Parse(Console.ReadLine());


    Console.Write("The first {0} natural numbers are: ", givenNumber);

    int sum = 0;
    //Loop to display and calculate the sum of the first 'n' numbers.
    for (int i = 1; i <= givenNumber; i++)
    {
        Console.Write("{0} ", i);
        sum += i;
    }
    Console.WriteLine();
    Console.WriteLine($"The sum of n numbers is: {sum}");

    Console.Write($"Would you like to try again? Y/N  ");
    string? userAnswer = Console.ReadLine();

    if (userAnswer?.ToLower() == "n")
    {
        continueAgain = false;
        Console.WriteLine($"Good bye!.");
    }
    else if (userAnswer?.ToLower() == "y")
    {
        continueAgain = true;
    }
} while (continueAgain);
