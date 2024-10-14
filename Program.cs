Console.Clear();
Console.WriteLine("what operator?");
string? opp = Console.ReadLine();
if (opp == "+") 
{
    Console.WriteLine("Provide 1 number to perform the addition operation");
    string? Num1 = Console.ReadLine();
    Console.WriteLine(Num1 + " …got it. Provide a number to add to " + Num1);
    string? Num2 = Console.ReadLine();
    string? Solution = Num1 + Num2;
    Console.WriteLine(Num2 + ", alright! Thats easy. " + Num1 + " + " + Num2 + " = " + Solution + "!");

}
else if (opp == "-")
{

}
else if (opp == "*")
{

}
else if (opp == "/")
{

}
else 
{
    Console.WriteLine("Invalid Opperator!");
}