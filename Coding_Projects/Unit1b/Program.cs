using System;
using System.Security.Cryptography;

Console.WriteLine("Hello! What Project Would You Like To Access?\n1. Lab1b\n2. Lab1c\n3. TempConverter");
string ProjectResult = Console.ReadLine();

switch (ProjectResult)
{
    case "1":
        Console.WriteLine("You have chosen Lab1b...\n\n\n");
        Lab1b();
        break;
    case "2":
        Console.WriteLine("You have Chosen Lab1c...\n\n\n");
        Lab1c();
        break;
    case "3":
        Console.WriteLine("You have Chosen Tempurature Converter\n\n\n");
        TempConverter();
        break;
    default:
        Console.WriteLine("You seemed to have inputed something wrong");
        break;
}




//Unitc 1c
static void Lab1c()
{
    Console.WriteLine("this is currently not working rn I am still working on it");
}



//Extra Work
static void TempConverter()
{
    var IncrementVar = 0;
    var EndProject = "";
    var Choice = "";

    Console.WriteLine("What would you like to convert? Just type in the number and hit enter!\n1. Celecius -> Fahrenheit\n2. Fahrenheit -> Celcius");
    var Result = Console.ReadLine();

    switch (Result)
    {
        case "1":
            Console.WriteLine("You have chosen C -> F");
            Choice = "Fahrenheit";
            break;
        case "2":
            Console.WriteLine("You have chosen F-> C");
            Choice = "Celcius";
            break;
        default:
            Console.WriteLine("There seems to be an error in your input...\nTry again.");
            TempConverter();
            break;
    }
    
    while (EndProject != "done")
    {
        if (IncrementVar == 0)
        {
            Console.WriteLine("What number would you like to convert?, if you are done type 'done'");
            IncrementVar++;
        }
        else Console.WriteLine("Input another number, type 'done' if you are done");
        var RequestedResult = Console.ReadLine();

        if (RequestedResult == "done") return;
        
        switch (Result)
        {
            case "2":
                RequestedResult = FtoC(RequestedResult);
                break;
            case "1":
                RequestedResult = CtoF(RequestedResult);
                break;
        }
        Console.WriteLine("The tempurature is " + RequestedResult + " Degrees " + Choice);
    }
    
    static string FtoC(string x)
    {
        if (Int32.TryParse(x, out int y))
        {
            int result = Int32.Parse(x);

            result = (result - 32) * 5 / 9;
            return result.ToString();
        }
        else return x;
    }
    
    static string CtoF(string x)
    {
        if (Int32.TryParse(x, out int y))
        {
            int result = Int32.Parse(x);

            result = (result * 9 / 5)  + 32;
            return result.ToString();
        }
        else return x;
    }
}


//Unit 1b
static void Lab1b()
{
    Console.WriteLine("What tempurature is it in celcius?");
    var userInput = Console.ReadLine();

    var checkInput = TestInput(userInput);

    while (checkInput != "true")
    {
        Console.WriteLine("Lets try this again...\nWhat tempurature is it in celcius?");
        userInput = Console.ReadLine();
        checkInput = TestInput(userInput);
    }

    int result = Int32.Parse(userInput);

    if (result > 30 && result < 50)
    {
        Console.WriteLine("It seems warm enough I would dress in something light");
    }
    else if (result <= 30 && result >= 0)
    {
        Console.WriteLine("I would dress up a little bit more");
    }
    else if (result < 0)
    {
        Console.WriteLine("You are getting to pretty extreme colds you should probably stay inside");
    }
    else
    {
        Console.WriteLine("That is some crazy heat I would take shelter");
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
            if (Int32.TryParse(InputVar, out int result2))
            {
                return "true";
            }
            else if (Double.TryParse(InputVar, out double result))
            {
                Console.WriteLine("Lets not put in any decimal places");
                return "double";
            }
            else
            {
                Console.WriteLine("That was not a number, try again");
                return "false";

            }
        }
    }
}