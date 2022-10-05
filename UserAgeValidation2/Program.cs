// See https://aka.ms/new-console-template for more information

//rakendus palub kasutajal sisestada oma vanuse
//kui kasutaja vanus on v2iksem kui 13, siis kuvatakse "you are too young to use Instagram"
//muul juhul kuvatakse "welcome to Instagram"

Console.WriteLine("Enter your age:");
int userAge = Int32.Parse(Console.ReadLine());
if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
} else
{
    Console.WriteLine("You are too young to use Instagram.");
}
