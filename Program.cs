    //Сформировать из массива другой массив состоящий из строк, длина которых <= 3
    Console.Clear();
    
    string[] strokes = {"Jeff", "Elo", "42", "Oleg"};
    
    List<string> list = new List<string>();
    
    for (int i = 0; i < strokes.Length; i ++)
    {
        if (strokes[i].Length <= 3) list.Add(strokes[i]);
    }
    
    string[] strokes3 = list.ToArray();

    ////Output////
    for (int i = 0; i < strokes.Length; i++) Console.Write($"{strokes[i]} ");
    
    Console.Write("-> ");
    
    for (int i = 0; i < strokes3.Length; i++)
    {
        Console.Write($"{strokes3[i]} ");
    }
