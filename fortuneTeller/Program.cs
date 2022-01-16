// See https://aka.ms/new-console-template for more information
//Programm ennustab, mis juhtub kasutajaga homme (kasutame randomit);
string[] predictions = { "win a million", "fall in love", "buy youtube premium", "join darkside for cookies" };
Random random = new Random();
int userNumber = random.Next(0, predictions.Length);
Console.WriteLine($"Today you will {predictions[userNumber]}");    

