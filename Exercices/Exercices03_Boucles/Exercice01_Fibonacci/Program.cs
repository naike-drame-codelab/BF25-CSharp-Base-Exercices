// Calculer les 25 premiers nombres de la suite de Fibonacci

//// F1 -> 1
//// F2 -> 1
//// F3 -> 1+1 = 2
//// F4 -> 1+2 = 3
//// F5 -> 2+3 = 5
//// F6 -> 3+5 = 8
//// FN -> FN-1 + FN-2


int fnMinus1 = 1, fnMinus2 = 1;
Console.WriteLine($"F1 : {fnMinus1}");
Console.WriteLine($"F2 : {fnMinus2}");

for (int i = 3; i <= 25; i++)
{
    int fn = fnMinus1 + fnMinus2;
    fnMinus2 = fnMinus1;
    fnMinus1 = fn;
    Console.WriteLine($"F{i} : {fn}");
}