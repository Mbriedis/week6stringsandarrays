// See https://aka.ms/new-console-template for more information
//programm küsib kasutajal sisestada oma ees- ja perekonnanime;
//programm kontrollib andmete pikkust
//programm kuvab kumb nendest on pikem 
Console.WriteLine("Tere, palun sisesta oma eesnimi");
string firstName = Console.ReadLine();
Console.WriteLine("Sisesta oma perenimi");
string lastName = Console.ReadLine();
int firstNameLenght = firstName.Length;
int lastNameLenght = lastName.Length;
int i = 0;
Console.WriteLine($"sinu eesnimes on {firstNameLenght} sümbolit, ja perenimes on {lastNameLenght} sümbolit");
 if  (firstNameLenght < lastNameLenght) { Console.WriteLine("sinu perenimi on pikem kui eesnimi"); }
    else if (firstNameLenght > lastName.Length) { Console.WriteLine("Sinu eesnimi on pikem kui perenimi"); }
else {Console.WriteLine("sinu ees-ja perenimes on võrdne arv sümboleid"); } 