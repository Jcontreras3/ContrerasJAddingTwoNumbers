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
        Console.Write($"Your first number: {num1}");
    }
    else if(!n1)
    {
        Console.WriteLine("Not a number");
    }

}
