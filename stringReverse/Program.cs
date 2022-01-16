// See https://aka.ms/new-console-template for more information
//programm kuvab kasutaja eesnime tagurpidi 
Console.WriteLine("Sisesta eesnimi");
string firstname = Console.ReadLine();
for (int i = firstname.Length - 1; i >= 0; i--)
    Console.Write(firstname[i]);
