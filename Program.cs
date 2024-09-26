// // See https://aka.ms/new-console-template for more information

// Console.WriteLine("Geef getal1: ");
// int getal1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Geef getal2: ");
// int getal2 = int.Parse(Console.ReadLine());

// Console.WriteLine("\nKies een operatie:");
// Console.WriteLine("1 - Optellen");
// Console.WriteLine("2 - Aftrekken");
// Console.WriteLine("3 - Delen");
// Console.WriteLine("4 - Vermenigvuldigen");

// string keuze = Console.ReadLine();

// if (keuze == "1")
// {
//     Console.WriteLine("Resultaat: " + (getal1 + getal2));
// }
// else if (keuze == "2")
// {
//     Console.WriteLine("Resultaat: " + (getal1 - getal2));
// }
// else if (keuze == "3")
// {
//     if (getal2 == 0)
//     {
//         Console.WriteLine("Fout: delen door nul is niet toegestaan.");
//     }
//     else
//     {
//         Console.WriteLine("Resultaat: " + (getal1 / (double)getal2));
//     }
// }
// else if (keuze == "4")
// {
//     Console.WriteLine("Resultaat: " + (getal1 * getal2));
// }
// else
// {
//     Console.WriteLine("Ongeldige keuze");
// }





// Console.WriteLine("price of the construction land: ");
// int construction = int.Parse(Console.ReadLine());

// Console.WriteLine("price of the building: ");
// int building = int.Parse(Console.ReadLine());

// Console.WriteLine("Total Price: " + total_price(construction, building));

// double total_price(int construction, int building) {
//     return (construction + building) * 1.21;
// }


// Welkomstbericht
Console.WriteLine("Welcome to the Clothing Store!");

// Aantal broeken
Console.WriteLine("Enter the number of trousers purchased: ");
int trousers = int.Parse(Console.ReadLine());

// Aantal T-shirts
Console.WriteLine("Enter the number of T-shirts purchased: ");
int tShirts = int.Parse(Console.ReadLine());

// Aantal vesten
Console.WriteLine("Enter the number of vests purchased: ");
int vests = int.Parse(Console.ReadLine());

// Toon het totaalbedrag
Console.WriteLine("Total Payable Amount: " + total_price(trousers, tShirts, vests));

// Functie om de totaalprijs te berekenen
double total_price(int trousers, int tShirts, int vests) {
    double trouserPrice = 70.5;
    double tShirtPrice = 20.89;
    double vestPrice = 100.3;

    return (trousers * trouserPrice) + (tShirts * tShirtPrice) + (vests * vestPrice);
}
