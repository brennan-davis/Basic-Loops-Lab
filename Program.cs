// Hello Loop - Lab Exercise 1
//do
//{
//    Console.WriteLine("Hello, World!");
//    Console.WriteLine("\nWould you like to continue? (y/n)");
//} while (Console.ReadLine() == "y");
//Console.WriteLine("Goodbye!");

// Integer Decrease Loop - Lab Exercise 2
//Console.WriteLine("Please input a whole number greater than 0:");
//bool inputIsInt = int.TryParse(Console.ReadLine(), out int input);
//while (!inputIsInt || input < 0)
//{
//    if (!inputIsInt)
//    {
//        Console.WriteLine("Please input a whole number greater than 0:");
//    }
//    else if (input < 0)
//    {
//        Console.WriteLine("Please input a positive number grater than 0:");
//    }
//    inputIsInt = int.TryParse(Console.ReadLine(), out input);
//}
//for (int i = input; i >= 0; i--)
//{
//    Console.Write($"{i} ");
//}
//Console.WriteLine();
//for (int i = 0; i <= input; i++)
//{
//    Console.Write($"{i} ");
//}

// First Attempt Door Unlock - Lab Exercise 3
//bool doorLocked = true;
//int code = 13579;
//int attempts = 0;
//while(doorLocked && attempts < 5) 
//{
//    Console.WriteLine("Please input the 5-digit passcode:");
//    bool codeIsInt = int.TryParse(Console.ReadLine(), out int codeInput);

//    if(code == codeInput)
//    {
//        doorLocked = false;
//        Console.WriteLine($"Congrats! You got the correct pin of {code}!");
//    }
//    attempts++;
//    if(attempts == 5)
//    {
//        Console.WriteLine("Sorry, you have failed 5 attempts. You have been locked out of this door.");
//    } else
//    {
//        Console.WriteLine($"Wrong Passcode! Try Again. You have {5 - attempts} attempts remaining.\n");
//    }
//}

// Final Exercise w/ stretch
bool doorLocked = true;
int code = 13579;
int attempts = 0;
while (doorLocked && attempts < 5)
{
    Console.WriteLine("Please input the 5-digit passcode:");
    bool codeIsInt = int.TryParse(Console.ReadLine(), out int codeInput);
    while (!codeIsInt)
    {
        codeIsInt = int.TryParse(Console.ReadLine(), out codeInput);
    }

    doorLocked = !(codeInput == code);
    attempts++;

    if (!doorLocked && attempts < 5)
    {
        Console.WriteLine($"Congrats! You got the correct pin of {code} in {attempts} attempts!");
    }
    else if (doorLocked && attempts == 5)
    {
        Console.WriteLine("Sorry, you have failed 5 attempts. You have been locked out of this door.");
    }
    else
    {
        Console.WriteLine($"Wrong Passcode! Try Again. You have {5 - attempts} attempts remaining.\n");
    }
}