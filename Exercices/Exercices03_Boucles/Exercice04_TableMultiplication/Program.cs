// A l’aide de boucles « for » afficher les 5 premières tables de multiplication en allant jusque « x20 »

//for (int table = 1; table <= 5; table++)
//{
//    for (int multiplier = 1; multiplier <= 20; multiplier++)
//    {
//        Console.Write($"{table} X {multiplier} = {table * multiplier}");
//        Console.Write("\t");
//    }
//    Console.Write("\n");
//}

// grâce au modulo, on peut éviter un double for :
for (int i = 0; i < 100; i++)
{
    int table = (i / 20) + 1;
    int multi = (i % 20) + 1;
    Console.WriteLine($"{table} X {multi} = {table * multi}");
}