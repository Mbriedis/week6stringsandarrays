// See https://aka.ms/new-console-template for more information
//programm kuvab konsoolis mitu 'h', 'o', ja 'l' tähte on lauses "Hello World!"
Console.WriteLine("Hello world!");
{
    string input = "Hello World!".ToLower();
    int hCounter = 0;
    int oCounter = 0;
    int lCounter = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == 'h')
            hCounter++;
        else if (input[i] == 'o')
            oCounter++;
        else if (input[i] == 'l')
            lCounter++;
    }
    Console.WriteLine($"Lauses on H tähtesid {hCounter}, O tähtesid {oCounter} ja L tähtesid {lCounter}");
   
}
