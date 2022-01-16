// See https://aka.ms/new-console-template for more information
//programm küsib kasutaja käest eesnime
//programm kuvab kasutaja eesnime pikkust

Console.WriteLine("Mis on sinu eesnimi?");
string firstName = Console.ReadLine();

int firstNameLenght = firstName.Length;
Console.WriteLine($"sinu eesnimes on {firstNameLenght} sümbolit");
