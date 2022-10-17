//Jovann Contreras
//Date 10/17/2022
//Getting to integers and adding them together with data validation.

Console.WriteLine("Welcome to Adding Two Numbers Together!!");
int num1;
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

int num2;
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
