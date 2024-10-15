static void Calc()
{
    Console.WriteLine("what operator? (+, -, *, /, %)");
    string? opp = Console.ReadLine();
    if (opp == "+") 
    {
        Console.WriteLine("Provide 1 number to perform the addition operation");
        float Num1 = float.Parse(Console.ReadLine());
        Console.WriteLine(Num1 + " …got it. Provide a number to add to " + Num1);
        float Num2 = float.Parse(Console.ReadLine());
        float? Solution = Num1 + Num2;
        Console.WriteLine(Num2 + ", alright! Thats easy. " + Num1 + " + " + Num2 + " = " + Solution + "!");

        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Calc();
    }

    else if (opp == "-")
    {
        Console.WriteLine("Provide 1 number to perform the subtraction operation");
        float Num1 = float.Parse(Console.ReadLine());
        Console.WriteLine(Num1 + " …got it. Provide a number to subtract to " + Num1);
        float Num2 = float.Parse(Console.ReadLine());
        float? Solution = Num1 - Num2;
        Console.WriteLine(Num2 + ", alright! Thats easy. " + Num1 + " - " + Num2 + " = " + Solution + "!");
        
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Calc();
    }

    else if (opp == "*")
    {
    Console.WriteLine("Provide 1 number to perform the multiplactaion operation");
        float Num1 = float.Parse(Console.ReadLine());
        Console.WriteLine(Num1 + " …got it. Provide a number to multiply to " + Num1);
        float Num2 = float.Parse(Console.ReadLine());
        float? Solution = Num1 * Num2;
        Console.WriteLine(Num2 + ", alright! Thats easy. " + Num1 + " * " + Num2 + " = " + Solution + "!");
        
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Calc();
    }

    else if (opp == "/")
    {
    Console.WriteLine("Provide 1 number to perform the division operation");
        float Num1 = float.Parse(Console.ReadLine());
        Console.WriteLine(Num1 + " …got it. Provide a number to divide to " + Num1);
        float Num2 = float.Parse(Console.ReadLine());
        float? Solution = Num1 / Num2;
        Console.WriteLine(Num2 + ", alright! Thats easy. " + Num1 + " / " + Num2 + " = " + Solution + "!");
        
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Calc();
    }

    else if (opp == "%")
    {
    Console.WriteLine("Provide 1 number to perform the modulus operation");
        float Num1 = float.Parse(Console.ReadLine());
        Console.WriteLine(Num1 + " …got it. Provide a number to Modulate to " + Num1);
        float Num2 = float.Parse(Console.ReadLine());
        float? Solution = Num1 % Num2;
        Console.WriteLine(Num2 + ", alright! Thats easy. " + Num1 + " % " + Num2 + " = " + Solution + "!");
        
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Calc();
    }
    else 
    {
        Console.WriteLine("Invalid Opperator!");
        Console.WriteLine("try writing (+, -, *, /, or %)");
        
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Calc();
    }
}

Console.Clear();
Calc();