// Calculer le nombre factoriel d'un nombre donné
//// 1! = 1
//// 2! = 1 * 2 = 2
//// 3! = 1 * 2 * 3 = 6
//// 4! = 1 * 2 * 3 * 4 = 24
//// n! = 1 * 2 * ... * n


bool isConverted;
int nb;

do
{
    Console.Write("Veuillez introduire un nombre entier : ");
    string input = Console.ReadLine() ?? "0";
    isConverted = int.TryParse(input, out nb);
} while (!isConverted);

decimal value = 1;
for (int i = 2; i <= nb; i++)
{
    checked
    {
        value *= i; // 6 * 5 * 4 * 3 * 2 * 1
    }
}

Console.WriteLine($"Le nombre factoriel de {nb} est {value}.");