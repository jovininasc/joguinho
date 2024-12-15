bool opt = false;
string[,] table = { {"a", " ", " ", " ", " "," ", " ", " ", " "," "," ", " ", " ", " "," "," "," ", " ", " ", " "," ", " ", " ", " "," "," ", " ", " ", " "," "," ", " "},
                    {" ", " ", " ", " ", " "," ", " ", " ", " "," "," ", " ", " ", " "," "," "," ", " ", " ", " "," ", " ", " ", " "," "," ", " ", " ", " "," "," ", " "},
                    {" ", " ", " ", " ", " "," ", " ", " ", " "," "," ", " ", " ", " "," "," "," ", " ", " ", " "," ", " ", " ", " "," "," ", " ", " ", " "," "," ", " "},
                    {"O", " ", " ", " ", " "," ", " ", " ", " "," "," ", " ", " ", " "," "," "," ", " ", " ", " "," ", " ", " ", " "," "," ", " ", " ", " "," "," ", "X"},
                    {" ", " ", " ", " ", " "," ", " ", " ", " "," "," ", " ", " ", " "," "," "," ", " ", " ", " "," ", " ", " ", " "," "," ", " ", " ", " "," "," ", " "},
                    {" ", " ", " ", " ", " "," ", " ", " ", " "," "," ", " ", " ", " "," "," "," ", " ", " ", " "," ", " ", " ", " "," "," ", " ", " ", " "," "," ", " "},
                    {"a", " ", " ", " ", " "," ", " ", " ", " "," "," ", " ", " ", " "," "," "," ", " ", " ", " "," ", " ", " ", " "," "," ", " ", " ", " "," "," ", " "}};

int row = 0, line = 3;

void Menu()
{
    Console.Write("Nick:");
    string nick = Console.ReadLine();
    Console.WriteLine("Press ENTER");
    var entrar = Console.ReadKey();
    if(entrar.Key == ConsoleKey.Enter) opt = true;

}

void PlayGame()
{
    while (opt == true)
    {
    Console.Clear();
    Console.WriteLine("===========================================");
    mapGame();
    Console.WriteLine("===========================================");
    var info = Console.ReadKey();

    switch (info.Key)
    {
        case ConsoleKey.UpArrow:
            if(line - 1 >= 0)
            {
                table[line, row] = " ";
                line--;
                table[line, row] = "O";  
            }
            
            continue;

        case ConsoleKey.DownArrow:
            if(line + 1 < table.GetLength(0))
            {
                table[line, row] = " ";
                line++;
                table[line, row] = "O";
            }
            
            continue;

        case ConsoleKey.LeftArrow:

            if(row - 1 > 0)
            {
                table[line, row] = " ";
                row--;
                table[line, row] = "O";
            }
            
            continue;

        case ConsoleKey.RightArrow:
            if(row + 1 < table.GetLength(1))
            {
                table[line, row] = " ";
                row++;
                table[line, row] = "O";
            }
            
            continue;
    }
        Menu();
    }
}

 void mapGame()
{
    for(int i = 0; i < table.GetLength(0); i++ )
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j]);
        }
        
        Console.WriteLine();
    }
}

Menu();
PlayGame();