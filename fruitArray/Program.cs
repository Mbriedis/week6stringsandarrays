// See https://aka.ms/new-console-template for more information
//programm ennustab mis puuvilja kasutaja sööb
string[] fruit = new string[5] { "an apple", "a banana", "a lemon", "an orange", "some grapes" };


//..Console.WriteLine(fruit[0]);
//Console.WriteLine(fruit[1]);
//Console.WriteLine("enter a number 0-4"));
Random random = new Random();   
int userNumber = random.Next(0, fruit.Length);  
Console.WriteLine($"Today you will have {fruit[userNumber]}.");
