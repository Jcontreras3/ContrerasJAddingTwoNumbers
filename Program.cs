//Jovann Contreras
//Date 10/17/2022
//Getting to integers and adding them together with data validation.


Console.Clear();
string playAgain = "yes";
while (playAgain == "yes")
{


    int result;
    int num1 = 0;
    int num2 = 0;
    Console.WriteLine("Welcome to Adding Two Numbers Together!!");
    bool n1 = false;
    while (!n1)
    {
        Console.WriteLine("Enter your first number");
        string NumberOne = Console.ReadLine();
        n1 = int.TryParse(NumberOne, out num1);

        if (n1)
        {
            Console.WriteLine($"Your first number: {num1}");
        }
        else if (!n1)
        {
            Console.WriteLine("Not a number");
        }

    }


    bool n2 = false;
    while (!n2)
    {
        Console.WriteLine("Enter your second number");
        string NumberTwo = Console.ReadLine();
        n2 = int.TryParse(NumberTwo, out num2);

        if (n2)
        {
            Console.WriteLine($"Your second number: {num2}");
        }
        else if (!n2)
        {
            Console.WriteLine("Not a number");
        }
    }

    result = num1 + num2;
    Console.WriteLine($"Answer: {result}");

    Console.WriteLine("Would you like to try again? type in Yes to retry or No to quit");
    playAgain = Console.ReadLine().ToLower();
    if (playAgain == "yes")
    {
        continue;
    }
    else if (playAgain == "no")
    {
        Console.WriteLine("Thanks for playing!");
    }
    else if (playAgain != "yes" || playAgain != "no")
    {
        Console.WriteLine("Not a valid pick please enter in Yes or No");
        playAgain = Console.ReadLine().ToLower();
    }
}