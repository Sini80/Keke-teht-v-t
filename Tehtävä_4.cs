// See https://aka.ms/new-console-template for more information

//Otsikon luonti
Console.WriteLine(" VALUUUTTALASKURI ");
Console.WriteLine("------------------");
// Muuttujan esittely
int luku1;
// kysytään lukua
Console.Write("Anna summa euroina ? ");
luku1 = int.Parse(Console.ReadLine());
Console.WriteLine();

//Euron kysely dollareina ja puntina
double dollari = luku1 * 1.21;
double punta = luku1 * 0.87;

// Laskee luvut ja muuttaa dollareiksí ja ounniksi eurot
string lasku = string.Format("{0,10:0.00}",dollari);
string lasku1 = string.Format("{0,10:0.00}", punta);
// Tulostetaan
Console.WriteLine(lasku + " $ ");
Console.WriteLine(lasku1 + " £ ");





