// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string input = "";
int hint = 0;
Console.WriteLine("Welcome to PTec scavenger hunt");
Console.WriteLine("Go to https://trcm.ca on the Lets Talk Treaties tab for your information");
Console.WriteLine("No uppercases");
Console.WriteLine("Question one: What treaty had the lagest number of first nation communities?");
Console.WriteLine("Ex: treaty # ");

do
{
    if (input != "")
    {
        Console.WriteLine("Wrong answer");
        hint++;
        if (hint == 3)
        {
            Console.WriteLine("Hint: Numbered");
        }
    }
    input = Console.ReadLine();
} while (input != "treaty 5");

Console.WriteLine("Correct");
Console.WriteLine("Question two: How does the Inniwak say [Scaed promises to one another]?");

hint = 0;
input = "";

do
{
    if (input != "")
    {
        Console.WriteLine("Wrong answer");
        hint++;
        if (hint == 3)
        {
            Console.WriteLine("Hint: What is");
        }
    }
    input = Console.ReadLine();
} while (input != "kitchi-astomatowin");

Console.WriteLine("Correct");
Console.WriteLine("Question three: What kind of document was the royal proclamation?");
Console.WriteLine("Ex: a _________ document");

hint = 0;
input = "";

do
{
    if (input != "")
    {
        Console.WriteLine("Wrong answer");
        hint++;
        if (hint == 3)
        {
            Console.WriteLine("Hint: Crown");
        }
    }
    input = Console.ReadLine();
} while (input != "a sweeping document");

Console.WriteLine("Correct");
Console.WriteLine("Question four: first Nations belieed that the Treaties would [__________] the transition to a new lifestyle that was taking hold at the of the 19th century.");

hint = 0;
input = "";

do
{
    if (input != "")
    {
        Console.WriteLine("Wrong answer");
        hint++;
        if (hint == 3)
        {
            Console.WriteLine("Hint: Benefits");
        }
    }
    input = Console.ReadLine();
} while (input != "facilitate");

Console.WriteLine("Correct");
Console.WriteLine("Question five: While Naton-to-Nation treaty making was done amoung leaders who else where intergral and valued in the process");
Console.WriteLine("Ex: first Nations __________, __________, and __________");

hint = 0;
input = "";

do
{
    if (input != "")
    {
        Console.WriteLine("Wrong answer");
        hint++;
        if (hint == 3)
        {
            Console.WriteLine("Hint: First");
        }
    }
    input = Console.ReadLine();
} while (input != "first nations women elders, and community members");
Console.WriteLine("Correct");
Console.WriteLine("Nice, you are done...");