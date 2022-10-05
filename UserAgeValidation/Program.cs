// See https://aka.ms/new-console-template for more information

//rakendus palub kasutajal valida tema sugu: mees või naine
//rakendus palub kasutajal sisestada tema parekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat jörgmiselt:
//"Welcome, Mr./Mrs. Kasutaja Perekonnanimi

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine());
Console.WriteLine("Please, enter your last name:");
string userLastName = Console.ReadLine();

if(userGender =='m')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}


else if(userGender =='f')
{
    Console.WriteLine($"Welcome, Ms.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome {userLastName}!");
}