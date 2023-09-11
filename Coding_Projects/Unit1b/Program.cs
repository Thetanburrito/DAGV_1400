using System;


Console.WriteLine("What tempurature is it in celcius?");
var userInput = Console.ReadLine();

var checkInput = TestInput(userInput);

while(checkInput != "true")
{
    Console.WriteLine("Lets try this again...\nWhat tempurature is it in celcius?");
    userInput = Console.ReadLine();
    checkInput = TestInput(userInput);
}

int result = Int32.Parse(userInput);

if (result > 30)
{
    Console.WriteLine("It seems warm enough I would dress in something light");
}
else
{
    Console.WriteLine("I would dress up a little bit more");
}


static string GetInput()
{
    return Console.ReadLine();
}



static string TestInput(string InputVar)
{
    if (InputVar == "")
    {
        Console.WriteLine("You forgot to input something");
        return "null";
    }
    else
    {
        if (Double.TryParse(InputVar, out double result))
        {
            Console.WriteLine("Lets not put in any decimal places");
            return "double";
        }
        else if (Int32.TryParse(InputVar, out int result2))
        {
            return "true";
        }
        else
        {
            Console.WriteLine("That was not a number, try again");
            return "false";

        }
    }
}












