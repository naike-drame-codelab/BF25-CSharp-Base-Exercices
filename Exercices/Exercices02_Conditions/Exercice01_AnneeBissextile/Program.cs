// 1. Demander dans la console une année
// afficher l'année est bissextile
// ou l'année n'est pas bissextile
// Exemples : 
// 1999 => pas bissextile
// 1996 => bissextile
// 1600 => bissextile
// 1700 pas bissextile


#region Réponse
Console.Write("Veuillez indiquer une année : ");
string input = Console.ReadLine();

if (int.TryParse(input, out int year))
{
    if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
    {
        Console.WriteLine($"L'année {year} est bissextile.");
    }
    else
    {
        Console.WriteLine($"L'année {year} n'est pas bissextile.");
    }
}
else
{
    Console.WriteLine($"La valeur \"{input}\" n'est pas une année valide.");
}

#endregion
