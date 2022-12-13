// Instansiating Calculator object 
CalculatorLibrary.Calculator CalculatorInstance = new CalculatorLibrary.Calculator();

Console.WriteLine(CalculatorInstance.add(2, 4));

static string? ShowMainMenu()
{
    Console.Write("Please select an operation index : \n" +
    "\t1 - To Add \n" +
    "\t2 - To Subtract \n" +
    "\t3 - To Multiply \n" +
    "\t4 - To Divide \n" +
    "\tEXIT - To Exit \n" +
    "Please enter the index : ");
    string? userResponse = Console.ReadLine();

    if (userResponse == null)
    {
        return null;
    }
    else return userResponse;
}

static void EnterValidResponse()
{
    Console.WriteLine("*************************");
    Console.WriteLine("Please enter a valid response");
    Console.WriteLine("*************************");
}

string? userResponse = ShowMainMenu();

while (userResponse != "Exit" && userResponse == null && int.TryParse(userResponse, out int intResponse))
{
    EnterValidResponse();
    userResponse = ShowMainMenu();
}

while (userResponse != "Exit")
{
    if (userResponse == "1")
    {
        Console.Write("Please enter num1 : ");
        string? num1 = Console.ReadLine();

        Console.Write("Please enter num2 : ");
        string? num2 = Console.ReadLine();

        if (num1 != null && num2 != null &&
            double.TryParse(num1, out double doubleNum1) &&
            double.TryParse(num2, out double doubleNum2))
        {
            Console.WriteLine(CalculatorInstance.add(doubleNum1, doubleNum2));
            userResponse = ShowMainMenu();
            continue;
            
        }
        else
        {
            EnterValidResponse();
            userResponse = ShowMainMenu();
            continue;
        }
    }

    else if (userResponse == "2")
    {
        Console.Write("Please enter num1 : ");
        string? num1 = Console.ReadLine();

        Console.Write("Please enter num2 : ");
        string? num2 = Console.ReadLine();

        if (num1 != null && num2 != null &&
            double.TryParse(num1, out double doubleNum1) &&
            double.TryParse(num2, out double doubleNum2))
        {
            Console.WriteLine(CalculatorInstance.sub(doubleNum1, doubleNum2));
            userResponse = ShowMainMenu();
            continue;
        }
        else
        {
            EnterValidResponse();
            userResponse = ShowMainMenu();
            continue;
        }
    }

    else if (userResponse == "3")
    {
        Console.Write("Please enter num1 : ");
        string? num1 = Console.ReadLine();

        Console.Write("Please enter num2 : ");
        string? num2 = Console.ReadLine();

        if (num1 != null && num2 != null &&
            double.TryParse(num1, out double doubleNum1) &&
            double.TryParse(num2, out double doubleNum2))
        {
            Console.WriteLine(CalculatorInstance.mul(doubleNum1, doubleNum2));
            userResponse = ShowMainMenu();
            continue;
        }
        else
        {
            EnterValidResponse();
            userResponse = ShowMainMenu();
            continue;
        }
    }

    else if (userResponse == "4")
    {
        Console.Write("Please enter num1 : ");
        string? num1 = Console.ReadLine();

        Console.Write("Please enter num2 : ");
        string? num2 = Console.ReadLine();

        if (num1 != null && num2 != null &&
            double.TryParse(num1, out double doubleNum1) &&
            double.TryParse(num2, out double doubleNum2))
        {
            Console.WriteLine(CalculatorInstance.div(doubleNum1, doubleNum2));
            userResponse = ShowMainMenu();
            continue;
        }
        else
        {
            EnterValidResponse();
            userResponse = ShowMainMenu();
            continue;
        }
    }

    else if (userResponse == "EXIT")
    {
        break;
    }

    else
    {
        userResponse = ShowMainMenu();
    }
}

