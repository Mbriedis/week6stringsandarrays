// See https://aka.ms/new-console-template for more information

//programm asendab kõik O tähed lauses "Dont Panic!" 0iga;
//programm asendab kõik A tähed samas lauses nr 4ga;
Console.WriteLine("Dont Panic!");
string dP = "Dont Panic!";
//for (int i = 0; i < helloW.Length; i++)
//helloW[i] //sõnad on konstantsed 
dP = dP.Replace('o', '0');
dP = dP.Replace('a', '4');
Console.WriteLine(dP);