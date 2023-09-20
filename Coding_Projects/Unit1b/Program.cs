using System;
using System.Security.Cryptography;

Console.WriteLine("Hello! What Project Would You Like To Access?\n1. Lab1b\n2. Lab1c\n3. Challenge1c\n4. Challenge1c Part2\n5. TempConverter");
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
        Console.WriteLine("You have Chosen Callenge1c\n\n\n");
        Challenge1c();
        break;
    case "4":
        Console.WriteLine("You have Chosen Challenge1c Part2\n\n\n");
        Challenge1c_();
        break;
    case "5":
        Console.WriteLine("You have Chosen Tempurature Converter\n\n\n");
        TempConverter();
        break;
    default:
        Console.WriteLine("You seemed to have inputed something wrong");
        break;
}




//Unitc Lab1c
static void Lab1c()
{
    //This is me creating an array then looping through it and writing the numbers that corespond with the placement
    Console.WriteLine("In this Unit we need to use arrays, and then use for loops to navigate them,");
    int[] numberArray = { 1, 2, 3, 4, 5, 6, 7, 8, };
    for (int i = 0; i < numberArray.Length; i++)
    {
        Console.WriteLine(i + ": " + numberArray[i]);
    }
    Console.WriteLine("In this example I have created an array and you can see that the corresponding numbers do not line up,\nthat is due to when counting arrays they start at 0");
    Console.WriteLine("We can use for loops for manythings, here is another example, you can number stack...\ngive me a number or a word and I will stack up to the number or number of letters in the word.");
    string forLoopIn = Console.ReadLine();
    string Stack = "";


    //Here it tests to see if the input above is an integer
    if (Int32.TryParse(forLoopIn, out int rnd))
    {
        //If it's an integer then this for loop loops as if calculating an integer
        for (int i = 1;i < Int32.Parse(forLoopIn) + 1; i++)
        {
            for (int x = 0; x < i; x++)
            {
                Stack = Stack + i;
            }
            Console.WriteLine(Stack);
            Stack = "";
        }

    }
    else
    {
        //If it wasn't an integer then it looks an ammount of times as the length of the string inputed
        for (int i = 1; i < forLoopIn.Length + 1; i++)
        {
            for (int x = 0; x < i; x++)
            {
                Stack = Stack + i;
            }
            Console.WriteLine(Stack);
            Stack = "";
        }

    }
}

//Unit 1c Lab
static void Challenge1c()
{
    //In this we have to create a random number generator and a let the view guess the number multiple times with lives
    Random rnd = new Random();
    int num = rnd.Next(100);
    Console.WriteLine("Alright I've already got a number, start guessing it's between 1 and 100");
    string guess = "-999";
    int Health = 10;
    Console.WriteLine("You have " + Health + " lives left");
    
    
    while (Int32.Parse(guess) != num)
    {
        if (Health > 0)
        {
            guess = Console.ReadLine();
            int guessInt = Int32.Parse(guess);
            int gotit = HotOrCold(guessInt, num, Health);
            if (gotit != 0)
            {
                Health--;
            }
        }
        else
        {
            Console.WriteLine("You've ran out of lives...\n\nThe number was " + num);
            break;
        }
        
    }

    static int HotOrCold(int Test, int RandNum,int Health_)
    {
        int test_ = RandNum - Test;


        if (test_ >= 50 || test_ <= -50)
        {
            Health_--;
            Console.WriteLine("Pretty far away\n" + "You have " + Health_ + " lives left");
            return test_;
        }
        else if (test_ >= 25 && test_ < 50 || test_ <= -25 && test_ > -50)
        {
            Health_--;
            Console.WriteLine("Far\n" + "You have " + Health_ + " lives left");
            return test_;
        }
        else if (test_ >= 10 && test_ < 25 || test_ <= -10 && test_ > -25)
        {
            Health_--;
            Console.WriteLine("You're within 25!\n" + "You have " + Health_ + " lives left");
            return test_;
        }
        else if (test_ != 0)
        {
            Health_--;
            Console.WriteLine("You are close! At least within 10\n" + "You have " + Health_ + " lives left");
            return test_;
        }
        else
        {
            Console.WriteLine("You got it!!!");
            return test_;
        }
    }




}

static void Challenge1c_()
{
    string Foods = "";
    List<string> foodList = new List<string>();
    Console.WriteLine("Give me a list of favourite foods, and then type 'done' when done.");
    while (Foods != "done")
    {
        Foods = Console.ReadLine();
        if (Foods != "done")
        {
            foodList.Add(Foods);
        }

    }
    for (int i = 0; i < foodList.Count; i++)
    {
        Console.WriteLine("I love " + foodList[i]);
    }
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