// See https://aka.ms/new-console-template for more information

//Muuttujan esittely
int luku1;
// Luodaan kysymys ja tulostetaan se.
Console.Write(" Anna pituutesi senttimetreinä ? ");
luku1 = int.Parse(Console.ReadLine());// Luetaan ensimmäinen luku1
Console.WriteLine();


//pituuden kysely ja luku
double metria = luku1 / 100;
double mailia = luku1 / 160934.4;
double jaardia = luku1 / 91.44;
double tuumaa = luku1 / 2.54;


// Kahden desimaalin tarkkuudella
string pituus1 = string.Format("{0:0.00}",metria);
string pituus2 = string.Format("{0:0.00}",mailia);
string pituus3 = string.Format("{0:0.00}",jaardia);
string pituus4 = string.Format("{0:0.00}",tuumaa);


//Tulostus näytölle
Console.WriteLine(pituus1 + " metria ");
Console.WriteLine(pituus2 + " mailia ");
Console.WriteLine(pituus3 + " jaardia ");
Console.WriteLine(pituus4 + " tuumaa ");





