// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//programm asendab kõik 'o' tähed lauses "Hello world!" tärniga
string helloW = "Hello World!";
//for (int i = 0; i < helloW.Length; i++)
//helloW[i] //sõnad on konstantsed 
helloW = helloW.Replace('o', '*');
helloW = helloW.Replace('!', '1');
Console.WriteLine(helloW);