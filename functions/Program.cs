

#region AllFunctions

// Task 1: Write a function that greets the user by name.
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.PortableExecutable;
using static System.Runtime.InteropServices.JavaScript.JSType;

string Information(string name)
{
    return "Welcom " + name;
}

// Task 2: Create a function to calculate the volume of a box (length * width * height).
Double calculate(double length, double width, double height)
{
    double total = (length * width * height);
    return total;

}
//Task 3: Create a function that takes in a number, and returns to you it’s square if it’s odd, or double if its even. 

double Number(double number)
{

    if (number % 2 == 0)
    {
        return number * 2;
    }
    else
    {
        return number * number;
    }

}
//Task 4: Write a function that converts a given temperature from Celsius to Fahrenheit.

double Temperature(double c)
{
    if (c == 0)
    {
        return 32;
    }
    else if (c > 0)
    {
        return (c * 9 / 5) + 32;
    }
    else
    {
        return (c * 9 / 5) + 32;
    }
}
//Task 5: Write a function that takes a single character and determines if it is a vowel or consonant.

//char lowerChar = char.ToLower(character);

//{

//    if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u')
//    {
//        return $"{character} is a vowel.";
//    }
//    else if (lowerChar >= 'a' && lowerChar <= 'z')
//    {
//        // Check if the character is a consonant
//        return $"{character} is a consonant.";
//    }
//    else
//    {
//        return $"{character} is not a valid alphabet character.";
//    }
//}


//    if (char == 'a' || char == 'e' || char == 'i' || char == 'o' || char== 'u')
//    {
//        return "vowel";

//    }
//    else if (char)
//    {
//        return "consonat";
//    }
//    else
//    {
//        return "not a letter";

//    }

//}


#endregion

#region CallFunctions
//task1 
Console.WriteLine("Enter your Name");
string n = Console.ReadLine();
Console.WriteLine(Information(n));
//task2
Console.WriteLine("-------------------------------");

Console.WriteLine("enter your length ;");
double lengh = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("enter your width ;");
double width = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("enter your height ;");
double height = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Total is ; " + calculate(lengh, width, height));

Console.WriteLine("-------------------------------");
//task3 

Console.WriteLine("enter your number");
double result = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("resoult is ;" + Number(result));

Console.WriteLine("-------------------------------");
///task4 

Console.WriteLine("enter the temperature");
double value = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("value is ;" + Temperature(value));


Console.WriteLine("-------------------------------");
//task5 
//char lowerChar = char.ToLower(character);
//Console.WriteLine("enter your character");
//double resultt = Convert.ToChar(Console.ReadLine());
//Console.WriteLine("yor character ; " + value(resultt));



#endregion