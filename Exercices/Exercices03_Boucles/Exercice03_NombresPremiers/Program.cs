// Grâce à une boucle « for », calculez les x premiers nombres premiers
Console.Write("Entrez un nombre : ");
int x = int.Parse(Console.ReadLine());
int count = 0;

Console.WriteLine($"Les {x} premiers nombres premiers sont :");

for (int number = 2; count < x; number++)
{
    bool isPrime = true;

    // Vérifier si le nombre est premier
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.Write(number + " ");
        count++;
    }
}