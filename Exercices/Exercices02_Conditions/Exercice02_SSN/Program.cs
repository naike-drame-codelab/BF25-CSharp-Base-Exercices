// 3. Demander dans la console d'enregistrer un registre national belge (xx.xx.xx-xxx.yy)
// afficher dans la console si le registre est valide ou non
// n'est pas valide :
// si le nombre de caractères est incorrect
// si les . ou les - sont mal placés
// si les x ne sont pas des chiffres valides
// si les chiffres de contrôle à la fin ne sont pas bons
// (97 - xxxxxxxxx) % 97 != yy => pas valide
// bonus: ajouter la règle de contrôle si né après 2000
// vous ne pouvez pas utiliser de regex !!!

// Exemple:
// 82.05.06-203.16
// 97 - (820506203 % 97) = 16

using System.Text.RegularExpressions;

Console.WriteLine("Entrez le registre nationale belge que vous souhaitez vérifier");
string input = Console.ReadLine() ?? "";

int year;
int month;
int day;
string cleanedString = input.Replace(".", "").Replace("-", "");

int toControl;
int controlNumber;

#region Solution avec multiples conditions de validation

//// xx.xx.xx-xxx.xx

//// vérifier le nombre de caractères
//if (input.Length != 15)
//{
//    Console.WriteLine("Invalide");
//}

//// vérifier le placement de points et des tirets
//else if (input[2] != '.' || input[5] != '.' || input[12] != '.' || input[8] != '-')
//{
//    Console.WriteLine("Invalide");
//}
//// vérifier que les 6 premiers caractères forment une date correcte
//else if (!int.TryParse(input[..2], out year))
//{
//    Console.WriteLine("Invalide");
//}
//else if (!int.TryParse(input[3..5], out month) || month > 12)
//{
//    Console.WriteLine("Invalide");
//}
//else if (!int.TryParse(input[6..8], out day) || day > 31)
//{
//    Console.WriteLine("Invalide");
//}
//// vérifier les chiffres de controle (97 - (xxxxxxxxx % 97)) == xx
//else if (
//    !int.TryParse(cleanedString[..9], out toControl) 
//    || !int.TryParse(cleanedString[^2..], out controlNumber)
//    || 97 - (toControl % 97) != controlNumber
//)
//{
//    Console.WriteLine("Invalide");
//}
//else
//{
//    Console.WriteLine("Valide");
//} 
#endregion

#region Solution avec Regex

string pattern = @"^\d{2}\.(0[1-9]|1[0-2])\.(0[1-9]|1[0-9]|2[0-9]|3[0-1])-\d{3}\.\d{2}$";
if (!new Regex(pattern).Match(input).Success)
{
    Console.WriteLine("Invalide");
}
else if (
    !int.TryParse(cleanedString[..9], out toControl)
    || !int.TryParse(cleanedString[^2..], out controlNumber)
    || 97 - (toControl % 97) != controlNumber
)
{
    Console.WriteLine("Invalide");
}
else
{
    Console.WriteLine("Valide");
} 
#endregion
