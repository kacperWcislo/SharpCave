

string []questions =["Jaka jest stolica Polski ?","Jaka jest stolica Włoch","Jaka jest stolica Niemiec ?"];
string[]answers =["Warszawa","Rzym","Berlin"];
Console.WriteLine("Let's play Kings of Intelligence ");
Console.WriteLine("enter the number of players");
int numberOfPlayers =int.Parse( Console.ReadLine());
int[]results =new int[numberOfPlayers];
while(true)
{
   
    for(int j = 0;j<questions.Length;j++)
    {
        for(int i =0;i<numberOfPlayers;i++)
        {
            Console.WriteLine($"player {i+1}");
            Console.WriteLine(questions[j]);
            string answer=Console.ReadLine();
            if (answer==answers[j])
            {
                 results[i]++;
            }
        }
    }
    Console.WriteLine("wyniki:");
     for(int i =0;i<numberOfPlayers;i++)
     {
       Console.WriteLine($"wynik gracza {i+1} : {results[i]}"); 
     }
     PokażNajlepszegoGracza(results);
     Console.WriteLine("Press q to close the game or somthing else to play once again  ");
    string info = Console.ReadLine();
    if (info =="q")
    {
        break;
    }
}

void PokażNajlepszegoGracza(int []results)
{
    int max =0; 
    
    for(int i=0;i<results.Length;i++)
    {
        if(results[i]>max)
        {
            max = results[i];
        }
    }
    Console.WriteLine("zwycięzca");
    for(int i=0;i<results.Length;i++)
    {
        if (results[i]==max)
        {
            Console.WriteLine($"gracz {i+1}");
        }
    }
}



