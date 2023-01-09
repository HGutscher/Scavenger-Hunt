// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string input = "";
int hint = 0;
Console.WriteLine("Welcome to PTec scavenger hunt");
Console.WriteLine("Go to https://trcm.ca on the Lets Talk Treaties tab for your information");
Console.WriteLine("Question one: What treaty hand the lagest number of first nation communities?");

do {
    if (input != "")
    {
        Console.WriteLine("Wrong answer");
        hint++;
        if (hint == 3)
        {
            Console.WriteLine("Hint: Numbered");
        }
        input = Console.ReadLine();
    }
}while (input != "Treaty 5" && input != "treaty 5");

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
        input = Console.ReadLine();
    }
} while (input != "Kitchi-astomatowin" && input != "kitchi-astomatowin");

Console.WriteLine("Correct");
Console.WriteLine("Question three: What kind of document was the royal proclamation?");

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
        input = Console.ReadLine();
    }
} while (input != "A sweeping Document" && input != "a sweeping Document" && input != "Sweeping Document" && input != "sweeping Document");

Console.WriteLine("Correct");
Console.WriteLine("Question four: First Nations belieed that the Treaties would __________ the transition to a new lifestyle that was taking hold at the of the 19th century.");

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
        input = Console.ReadLine();
    }
} while (input != "Facilitate" && input != "facilitate");

Console.WriteLine("Correct");
Console.WriteLine("Question five: While Naton-to-Nation treaty making was done amoung leaders who else where intergral and valued in the process");

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
        input = Console.ReadLine();
    }
} while (input != "First Nations women, Elders  and community members" 
    && input != "First Nations women, elders  and community members"
    && input != "First nations women, elders  and community members"
    && input != "first nations women, elders  and community members"
    && input != "First Nations women Elders  and community members"
    && input != "First Nations women elders  and community members"
    && input != "First nations women elders  and community members"
    && input != "first nations women elders  and community members"
    );

Console.WriteLine("Correct");
Console.WriteLine("Nice you done...");