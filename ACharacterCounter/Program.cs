// See https://aka.ms/new-console-template for more information
//programm palub kasutajal sisestada ees- ja perekonnanime 
//programm kuvab, mitu "a" tähte on on kasutaja ees - ja perenimes kokku

Console.WriteLine("Palun sisesta oma Ees ja perenimi");
string firstname = Console.ReadLine().ToLower();
string lastname = Console.ReadLine().ToLower();
string fullname= $"{firstname}{lastname}".ToLower();    
int aCounter = 0;
for (int i = 0; i <  fullname.Length; i++)
    if (fullname[i] == 'a')
        aCounter++;
if (aCounter != 1)
    Console.WriteLine($"Sinu nimes {fullname} on {aCounter} 'a' tähte");
else Console.WriteLine($"Sinu nimes {fullname} on {aCounter} 'a' täht");